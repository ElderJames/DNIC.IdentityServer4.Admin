using DNIC.IdentityServer4.Admin.Filters;
using DNIC.IdentityServer4.Admin.Service;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNIC.IdentityServer4.Admin.Controllers
{
	[NoCache]
	[Route("api/[controller]")]
	//[Authorize(Roles = "superadmin")]
	public class ApiResourceController : Controller
	{
		private readonly IResourceService _apiResourceService;

		public ApiResourceController(IResourceService apiResourceService)
		{
			_apiResourceService = apiResourceService;
		}

		[HttpGet]
		public async Task<IEnumerable<Client>> GetAll()
		{
			return await _apiResourceService.GetAll();
		}
	}
}
