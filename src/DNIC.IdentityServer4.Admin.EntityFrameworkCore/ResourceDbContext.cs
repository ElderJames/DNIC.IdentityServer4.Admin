using AutoMapper;
using DNIC.IdentityServer4.Admin.Core;
using IdentityServer4.EntityFramework.Interfaces;
using IdentityServer4.EntityFramework.Mappers;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNIC.IdentityServer4.Admin.EntityFrameworkCore
{
	public class ResourceDbContext : IResourceDbContext
	{
		private readonly IConfigurationDbContext _configurationDbContext;

		public ResourceDbContext(IConfigurationDbContext configurationDbContext)
		{
			_configurationDbContext = configurationDbContext;
		}

		public async Task AddApiResource(ApiResource entity)
		{
			await _configurationDbContext.ApiResources.AddAsync(entity.ToEntity());
		}

		public async Task AddClient(Client entity)
		{
			await _configurationDbContext.Clients.AddAsync(entity.ToEntity());
		}

		public async Task AddIdentityResource(IdentityResource entity)
		{
			await _configurationDbContext.IdentityResources.AddAsync(entity.ToEntity());
		}

		public Task<IEnumerable<Client>> GetAll()
		{
			return Task.FromResult(Mapper.Map<IEnumerable<Client>>(_configurationDbContext.Clients.ToArray()));
		}

		public void Dispose()
		{
		}
	}
}
