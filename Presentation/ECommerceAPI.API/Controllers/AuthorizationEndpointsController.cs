using ECommerceAPI.Application.Features.Commands.AuthorizationEndpoint.AssignRoleEndpoint;
using ECommerceAPI.Application.Features.Queries.AuthorizationEndpoint.GetEndpointRoles;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationEndpointsController : ControllerBase
    {
        readonly IMediator _mediator;

        public AuthorizationEndpointsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AssignRoleEndpoint(AssignRoleEndpointCommandRequest assignRoleEndpointCommandRequest)
        {
            assignRoleEndpointCommandRequest.Type = typeof(Program);
            var response = await _mediator.Send(assignRoleEndpointCommandRequest);
            return Ok(response);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> GetEndpointRoles([FromBody] GetEndpointRolesQueryRequest getEndpointRolesQueryRequest)
        {
            var response = await _mediator.Send(getEndpointRolesQueryRequest);
            return Ok(response);
        }
    }
}
