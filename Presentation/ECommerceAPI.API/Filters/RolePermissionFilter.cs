﻿using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.CustomAttributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Net;
using System.Reflection;

namespace ECommerceAPI.API.Filters
{
    public class RolePermissionFilter : IAsyncActionFilter
    {
        readonly IUserService _userService;

        public RolePermissionFilter(IUserService userService)
        {
            _userService = userService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var name = context.HttpContext.User.Identity?.Name;
            if (!string.IsNullOrEmpty(name) && name != "admin")
            {
                var descriptor = context.ActionDescriptor as ControllerActionDescriptor;

                var attribute = descriptor.MethodInfo.GetCustomAttribute<AuthorizeDefinitionAttribute>();
                var httpAttr = descriptor.MethodInfo.GetCustomAttribute<HttpMethodAttribute>();

                if (attribute != null)
                {
                    var code = $"{(httpAttr != null ? httpAttr.HttpMethods.First() : HttpMethods.Get)}.{attribute.ActionType}.{attribute.Definition.Replace(" ", "")}";

                    var hasRole = await _userService.HasRolePermissionToEndpointAsync(name, code);

                    if (!hasRole)
                    {
                        context.Result = new StatusCodeResult((int)HttpStatusCode.Forbidden);
                        return;
                    }
                }
                await next();
            }
            else
            {
                await next();
            }
        }
    }
}
