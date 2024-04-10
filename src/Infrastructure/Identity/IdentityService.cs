using QCheck.Application.Common.Interfaces;
using QCheck.Application.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QCheck.Application.Authentication.Commands.LoginUser.Model;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace QCheck.Infrastructure.Identity;

public class IdentityService : IIdentityService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IUserClaimsPrincipalFactory<ApplicationUser> _userClaimsPrincipalFactory;
    private readonly IAuthorizationService _authorizationService;
    private readonly IConfiguration _configuration;

    public IdentityService(
        UserManager<ApplicationUser> userManager,
        IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory,
        IAuthorizationService authorizationService,
        SignInManager<ApplicationUser> signInManager,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _userClaimsPrincipalFactory = userClaimsPrincipalFactory;
        _authorizationService = authorizationService;
        _signInManager = signInManager;
        _configuration = configuration;
    }

    public async Task<string?> GetUserNameAsync(string userId)
    {
        var user = await _userManager.Users.FirstAsync(u => u.Id == userId);

        return user.UserName;
    }

    public async Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
    {
        var user = new ApplicationUser
        {
            UserName = userName,
            Email = userName,
        };

        var result = await _userManager.CreateAsync(user, password);

        return (result.ToApplicationResult(), user.Id);
    }

    public async Task<bool> IsInRoleAsync(string userId, string role)
    {
        var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

        return user != null && await _userManager.IsInRoleAsync(user, role);
    }

    public async Task<bool> AuthorizeAsync(string userId, string policyName)
    {
        var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

        if (user == null)
        {
            return false;
        }

        var principal = await _userClaimsPrincipalFactory.CreateAsync(user);

        var result = await _authorizationService.AuthorizeAsync(principal, policyName);

        return result.Succeeded;
    }

    public async Task<Result> DeleteUserAsync(string userId)
    {
        var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

        return user != null ? await DeleteUserAsync(user) : Result.Success();
    }

    public async Task<Result> DeleteUserAsync(ApplicationUser user)
    {
        var result = await _userManager.DeleteAsync(user);

        return result.ToApplicationResult();
    }

    public async Task<ResultDto<string>> LoginUserAsync(SiginModel siginModel)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(siginModel.Email);
            if (user == null)
            {
                Console.WriteLine($"User not found for email: {siginModel.Email}");
                return new ResultDto<string>("User not found", false);
            }

            var result = await _signInManager.PasswordSignInAsync(siginModel.Email.Trim(), siginModel.Password.Trim(), false, false);

            if (result.IsLockedOut)
            {
                return new ResultDto<string>("User account locked", false);
            }

            if (result.Succeeded)
            {
                var token = GenerateJwtToken(siginModel.Email);
                return new ResultDto<string>(token, true);
            }
            else
            {
                if (user.AccessFailedCount >= 3 && user.AccessFailedCount <= 4)
                {
                    return new ResultDto<string>("Warning: Account about to be locked", false);
                }
                else
                {
                    return new ResultDto<string>("Invalid email or password", false);
                }
            }
        }
        catch (Exception ex)
        {
            // Log the exception
            Console.WriteLine($"Exception occurred: {ex}");
            return new ResultDto<string>("An error occurred during login", false);
        }
    }

    private string GenerateJwtToken(string email)
    {
        var authClaims = new List<Claim>()
            {
                new(ClaimTypes.Name, email),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

        var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]!));
        var token = new JwtSecurityToken(
            issuer: _configuration["JWT:ValidAudience"],
            audience: _configuration["JWT:ValidIssuer"],
            expires: DateTime.Now.AddHours(1),
            claims: authClaims,
            signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

}
