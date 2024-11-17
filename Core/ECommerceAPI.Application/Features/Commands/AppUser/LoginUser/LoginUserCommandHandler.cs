using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.DTOs;
using MediatR;

namespace ECommerceAPI.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        readonly IAuthService _authService;

        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            Token token = await _authService.LoginAsync(request.UserNameOrEmail, request.Password, 9000);
            return new LoginUserSuccessCommandResponse { Token = token };
        }
    }
}
