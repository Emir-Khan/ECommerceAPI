using ECommerceAPI.Application.Abstractions.Services;
using MediatR;

namespace ECommerceAPI.Application.Features.Queries.AppUser.GetUserRoles
{
    public class GetUserRolesQueryRequest : IRequest<GetUserRolesQueryResponse>
    {
        public string UserId { get; set; }
    }
}