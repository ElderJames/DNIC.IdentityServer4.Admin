using IdentityServer4.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNIC.IdentityServer4.Admin.Core
{
	/// <summary>
	/// Here need more apis like query
	/// </summary>
	public interface IResourceDbContext : IDisposable
	{
		Task<IEnumerable<Client>> GetAll();
		Task AddClient(Client entity);
		Task AddIdentityResource(IdentityResource entity);
		Task AddApiResource(ApiResource entity);
	}
}
