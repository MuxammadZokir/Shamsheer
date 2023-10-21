﻿using Shamsheer.Data.Repositories;
using Shamsheer.Data.IRepositories;
using Shamsheer.Service.Services.Users;
using Shamsheer.Service.Services.Groups;
using Shamsheer.Service.Interfaces.Users;
using Shamsheer.Service.Interfaces.Groups;
using Shamsheer.Service.Services.UserGroups;
using Shamsheer.Service.Interfaces.UserGroup;
using Shamsheer.Service.Services.Authorizations;
using Shamsheer.Service.Interfaces.Authorizations;
using Shamsheer.Service.Interfaces.Authorizations.Channels;
using Shamsheer.Service.Services.Authorizations.Channels;
using Shamsheer.Service.Interfaces.Channels;
using Shamsheer.Service.Services.Channels;

namespace Shamsheer.Messenger.Api.Extensions;

public static class ServiceExtensions
{
    public static void AddCustomService(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IGroupService, GroupService>();
        services.AddScoped<IChannelService, ChannelService>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IGroupRepository, GroupRepository>();
        services.AddScoped<IGroupRoleService, GroupRoleService>();
        services.AddScoped<IUserGroupService, UserGroupService>();
        services.AddScoped<IChannelRepository, ChannelRepository>();
        services.AddScoped<IChannelRoleService, ChannelRoleService>();
        services.AddScoped<IGroupRoleRepository, GroupRoleRepository>();
        services.AddScoped<IUserGroupRepository, UserGroupRepository>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IChannelRoleRepository, ChannelRoleRepository>();
        services.AddScoped<IGroupPermissionService, GroupPermissionService>();
        services.AddScoped<IChannelPermissionService, ChannelPermissionService>();
        services.AddScoped<IGroupPermissionRepository, GroupPermissionRepository>();
        services.AddScoped<IChannelPermissionRepository, ChannelPermissionRepository>();
    }
}