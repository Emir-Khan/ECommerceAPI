using ECommerceAPI.Application.Abstractions.Services;
using MediatR;

namespace ECommerceAPI.Application.Features.Queries.Role.GetRoles
{
    public class GetRolesQueryHandler : IRequestHandler<GetRolesQueryRequest, GetRolesQueryResponse>
    {
        readonly IRoleService _roleService;

        public GetRolesQueryHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetRolesQueryResponse> Handle(GetRolesQueryRequest request, CancellationToken cancellationToken)
        {
            var (data, count) = _roleService.GetAllRoles(request.Page, request.Size);
            return new()
            {
                Data = data,
                TotalRoleCount = count
            };
        }
    }
}
