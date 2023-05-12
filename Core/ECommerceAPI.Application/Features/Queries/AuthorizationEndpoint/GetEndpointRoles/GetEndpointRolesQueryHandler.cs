using ECommerceAPI.Application.Abstractions.Services;
using MediatR;

namespace ECommerceAPI.Application.Features.Queries.AuthorizationEndpoint.GetEndpointRoles
{
    public class GetEndpointRolesQueryHandler : IRequestHandler<GetEndpointRolesQueryRequest, GetEndpointRolesQueryResponse>
    {
        readonly IAuthorizationEndpointService _authorizationEndpointService;

        public GetEndpointRolesQueryHandler(IAuthorizationEndpointService authorizationEndpointService)
        {
            _authorizationEndpointService = authorizationEndpointService;
        }

        public async Task<GetEndpointRolesQueryResponse> Handle(GetEndpointRolesQueryRequest request, CancellationToken cancellationToken)
        => new()
        {
            Roles = await _authorizationEndpointService.GetEndpointRolesAsync(request.Code,request.Name)
        };
    }
}
