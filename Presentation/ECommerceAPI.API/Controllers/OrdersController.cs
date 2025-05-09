﻿using ECommerceAPI.Application.Consts;
using ECommerceAPI.Application.CustomAttributes;
using ECommerceAPI.Application.Enums;
using ECommerceAPI.Application.Features.Commands.Order.CompleteOrder;
using ECommerceAPI.Application.Features.Commands.Order.CreateOrder;
using ECommerceAPI.Application.Features.Queries.Order.GetAllOrders;
using ECommerceAPI.Application.Features.Queries.Order.GetOrderById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class OrdersController : ControllerBase
    {
        readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Orders, ActionType = ActionType.Writing, Definition = "Create Order")]
        public async Task<IActionResult> CreateOrder(CreateOrderCommandRequest createOrderCommandRequest)
        {
            await _mediator.Send(createOrderCommandRequest);
            return Ok();
        }
        [HttpGet]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Orders, ActionType = ActionType.Reading, Definition = "Get All Orders")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllOrderQueryRequest getAllOrderQueryRequest)
        {
            var response = await _mediator.Send(getAllOrderQueryRequest);
            return Ok(response);
        }
        [HttpGet("{Id}")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Orders, ActionType = ActionType.Reading, Definition = "Get Order Details By Id")]
        public async Task<IActionResult> GetOrderDetailsById([FromRoute] GetOrderByIdQueryRequest getOrderByIdQueryRequest)
        {
            var response = await _mediator.Send(getOrderByIdQueryRequest);
            return Ok(response);
        }
        [HttpGet("complete-order/{Id}")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Orders, ActionType = ActionType.Updating, Definition = "Complete Order")]
        public async Task<IActionResult> CompletedOrder([FromRoute] CompleteOrderCommandRequest completeOrderCommandRequest)
        {
            var response = await _mediator.Send(completeOrderCommandRequest);
            return Ok(response);
        }
    }
}
