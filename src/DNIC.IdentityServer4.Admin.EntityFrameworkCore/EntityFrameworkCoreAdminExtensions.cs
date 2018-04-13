using AutoMapper;
using DNIC.IdentityServer4.Admin.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using ID4M = IdentityServer4.Models;
using ID4EFM = IdentityServer4.EntityFramework.Entities;
using DNIC.IdentityServer4.Admin;

namespace DNIC.IdentityServer4.Admin.EntityFrameworkCore
{
	public static class EntityFrameworkCoreAdminExtensions
	{
		public static IServiceCollection AddEntityFrameworkCoreAdmin(this IServiceCollection services)
		{
			Mapper.Initialize(config =>
			{
				config.CreateMap<ID4EFM.Client, ID4M.Client>();
			});
			services.AddTransient<IResourceDbContext, ResourceDbContext>();

			services.AddAdmin();
			return services;
		}
	}
}
