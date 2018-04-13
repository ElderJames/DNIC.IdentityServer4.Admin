using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DNIC.IdentityServer4.Admin.Service
{
	public interface IResourceService
	{
		Task AddApiResource(ApiResource apiResource);
		Task<IEnumerable<Client>> GetAll();
	}
}
