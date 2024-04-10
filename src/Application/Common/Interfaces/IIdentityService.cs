using QCheck.Application.Authentication.Commands.LoginUser.Model;
using QCheck.Application.Common.Models;

namespace QCheck.Application.Common.Interfaces;

public interface IIdentityService
{
    Task<string?> GetUserNameAsync(string userId);

    Task<bool> IsInRoleAsync(string userId, string role);

    Task<bool> AuthorizeAsync(string userId, string policyName);

    Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

    Task<Result> DeleteUserAsync(string userId);
    Task<ResultDto<string>> LoginUserAsync(SiginModel siginModel);
}
