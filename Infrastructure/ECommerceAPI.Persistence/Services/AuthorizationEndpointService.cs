using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.Abstractions.Services.Configurations;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistence.Services
{
    public class AuthorizationEndpointService : IAuthorizationEndpointService
    {
        readonly IApplicationService _applicationService;
        readonly IEndpointReadRepository _endpointReadRepository;
        readonly IEndpointWriteRepository _endpointWriteRepository;
        readonly IMenuReadRepository _menuReadRepository;
        readonly IMenuWriteRepository _menuWriteRepository;
        readonly RoleManager<AppRole> _roleManager;

        public AuthorizationEndpointService(IApplicationService applicationService, IEndpointReadRepository endpointReadRepository, IEndpointWriteRepository endpointWriteRepository, IMenuWriteRepository menuWriteRepository, IMenuReadRepository menuReadRepository, RoleManager<AppRole> roleManager)
        {
            _applicationService = applicationService;
            _endpointReadRepository = endpointReadRepository;
            _endpointWriteRepository = endpointWriteRepository;
            _menuWriteRepository = menuWriteRepository;
            _menuReadRepository = menuReadRepository;
            _roleManager = roleManager;
        }

        public async Task AssignRoleEndpointAsync(string[] roles, string menu, string code, Type type)
        {
            Menu? singleMenu = await _menuReadRepository.GetSingleAsync(m => m.Name == menu);
            if (singleMenu == null)
            {
                singleMenu = new Menu { Id = Guid.NewGuid(), Name = menu };
                await _menuWriteRepository.AddAsync(singleMenu);
                await _menuWriteRepository.SaveAsync();
            }

            Endpoint? endpoint = await _endpointReadRepository.Table.Include(e => e.Menu)
                .Include(e => e.Roles).FirstOrDefaultAsync(e => e.Code == code && e.Menu.Name == menu);
            if (endpoint == null)
            {
                var action = _applicationService.GetAuthorizeDefinitionEndpoints(type).FirstOrDefault(m => m.Name == menu)?.Actions.FirstOrDefault(e => e.Code == code);

                endpoint = new()
                {
                    Code = action.Code,
                    ActionType = action.ActionType,
                    HttpType = action.HttpType,
                    Definition = action.Definition,
                    Menu = singleMenu,
                    Id = Guid.NewGuid()
                };
                await _endpointWriteRepository.AddAsync(endpoint);
                await _endpointWriteRepository.SaveAsync();
            }

            foreach (var role in endpoint.Roles)
                endpoint.Roles.Remove(role);

            var appRoles = await _roleManager.Roles.Where(r => roles.Contains(r.Name)).ToListAsync();

            foreach (var role in appRoles)
                endpoint.Roles.Add(role);

            await _endpointWriteRepository.SaveAsync();
        }

        public async Task<List<string>> GetEndpointRolesAsync(string code, string name)
        {
            Endpoint? endpoint = await _endpointReadRepository.Table.Include(e => e.Roles).Include(e => e.Menu).FirstOrDefaultAsync(e => e.Code == code && e.Menu.Name == name);
            return endpoint?.Roles.Select(r => r.Name).ToList();
        }
    }
}
