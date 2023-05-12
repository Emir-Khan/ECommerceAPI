using MediatR;

namespace ECommerceAPI.Application.Features.Queries.AuthorizationEndpoint.GetEndpointRoles
{
    public class GetEndpointRolesQueryRequest : IRequest<GetEndpointRolesQueryResponse>
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}