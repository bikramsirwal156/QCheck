using System.ComponentModel.DataAnnotations;
using QCheck.Application.Authentication.Commands.LoginUser.Model;
using QCheck.Application.Common.Interfaces;
using QCheck.Application.Common.Models;

namespace QCheck.Application.Authentication.Commands.LoginUser;
public class LoginCommand : IRequest<ResultDto<string>>
{
    [EmailAddress]   
    public required string Email { get; set; }

    public required string Password { get; set; }

    public class Handler : IRequestHandler<LoginCommand, ResultDto<string>>
    {
        private readonly IIdentityService _identityService;

        public Handler(IIdentityService identityService)
        {
            _identityService = identityService;
        }
        public async Task<ResultDto<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var siginModel = new SiginModel() { Email = request.Email, Password = request.Password };
                var result = await _identityService.LoginUserAsync(siginModel);
                if (result.IsSuccess)
                {
                    return new ResultDto<string>(result.Data,result.IsSuccess,result.Message,result.ErrorDetails);
                }
            }
            catch (Exception)
            {


            }
            return new ResultDto<string>("false", true);
        }
    }
}
