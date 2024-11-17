using ECommerceAPI.Application.Consts;
using ECommerceAPI.Application.CustomAttributes;
using ECommerceAPI.Application.Enums;
using ECommerceAPI.Application.Features.Commands.AuthorizationEndpoint.AssignRoleEndpoint;
using ECommerceAPI.Application.Features.Queries.AuthorizationEndpoint.GetEndpointRoles;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes ="Admin")]
    public class AuthorizationEndpointsController : ControllerBase
    {
        readonly IMediator _mediator;

        public AuthorizationEndpointsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Endpoints, ActionType = ActionType.Writing, Definition = "Assign Role to Endpoint")]
        public async Task<IActionResult> AssignRoleEndpoint(AssignRoleEndpointCommandRequest assignRoleEndpointCommandRequest)
        {
            assignRoleEndpointCommandRequest.Type = typeof(Program);
            var response = await _mediator.Send(assignRoleEndpointCommandRequest);
            return Ok(response);
        }
        [HttpPost("[action]")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Endpoints, ActionType = ActionType.Reading, Definition = "Get Endpoint Roles")]
        public async Task<IActionResult> GetEndpointRoles([FromBody] GetEndpointRolesQueryRequest getEndpointRolesQueryRequest)
        {
            var response = await _mediator.Send(getEndpointRolesQueryRequest);
            return Ok(response);
        }
    }
}
