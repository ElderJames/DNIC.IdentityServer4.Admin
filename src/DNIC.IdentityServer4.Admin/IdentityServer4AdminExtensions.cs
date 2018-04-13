using System;
using System.Collections.Generic;
using System.Text;
using DNIC.IdentityServer4.Admin.Service;
using Microsoft.Extensions.DependencyInjection;

namespace DNIC.IdentityServer4.Admin
{
	public static class IdentityServer4AdminExtensions
	{
		public static IServiceCollection AddAdmin(this IServiceCollection services)
		{
			services.AddScoped<IResourceService, ResourceService>();
			return services;
		}
	}
}
