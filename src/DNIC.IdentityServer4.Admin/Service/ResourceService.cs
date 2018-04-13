using DNIC.IdentityServer4.Admin.Core;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DNIC.IdentityServer4.Admin.Service
{
	public class ResourceService : IResourceService
	{
		private readonly IResourceStore _resourceStore;
		private readonly IResourceDbContext _resourceDbContext;

		public ResourceService(IResourceStore resourceStore, IResourceDbContext resourceDbContext)
		{
			_resourceStore = resourceStore;
			_resourceDbContext = resourceDbContext;
		}

		public async Task AddApiResource(ApiResource apiResource)
		{
			await _resourceDbContext.AddApiResource(apiResource);
		}

		public async Task<IEnumerable<Client>> GetAll()
		{
			return await _resourceDbContext.GetAll();
		}
	}
}
