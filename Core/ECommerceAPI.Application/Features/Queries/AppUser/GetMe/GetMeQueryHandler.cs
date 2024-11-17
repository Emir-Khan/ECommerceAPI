using ECommerceAPI.Application.Abstractions.Services;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace ECommerceAPI.Application.Features.Queries.AppUser
{
    public class GetMeQueryHandler : IRequestHandler<GetMeQueryRequest, GetMeQueryResponse>
    {
        IUserService _userService;
        IHttpContextAccessor _contextAccessor;
        public GetMeQueryHandler(IUserService userService, IHttpContextAccessor contextAccessor)
        {
            _userService = userService;
            _contextAccessor = contextAccessor;
        }

        public async Task<GetMeQueryResponse> Handle(GetMeQueryRequest request, CancellationToken cancellationToken)
        {
            var userName = _contextAccessor?.HttpContext?.User?.Identity?.Name;
            var userDetail = await _userService.GetUserDetailAsync(userName);

            return new()
            {
                Id = userDetail.Id,
                NameSurname = userDetail.NameSurname,
                Email = userDetail.Email,
                UserName = userDetail.UserName,
                Roles = userDetail.Roles,
            };
        }
    }

    public class GetMeQueryRequest : IRequest<GetMeQueryResponse>
    {
    }

    public class GetMeQueryResponse
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string[] Roles { get; set; }
    }
}
