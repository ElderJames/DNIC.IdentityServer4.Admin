using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DNIC.IdentityServer4.Admin.Filters
{
	/// <summary>
	/// 我不知道为什么要设置为不缓存
	/// </summary>
	class NoCacheAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuted(ActionExecutedContext actionExecutedContext)
		{
			base.OnActionExecuted(actionExecutedContext);
			if (actionExecutedContext != null &&
				actionExecutedContext.HttpContext.Request != null &&
				// TODO: 移植 EnsureSuccessStatusCode 方法过来
				actionExecutedContext.HttpContext.Response.StatusCode == 200
				)
			{
				var cc = new System.Net.Http.Headers.CacheControlHeaderValue();
				cc.NoStore = true;
				cc.NoCache = true;
				cc.Private = true;
				cc.MaxAge = TimeSpan.Zero;
				actionExecutedContext.HttpContext.Response.Headers.Add("Cache-Control", cc.ToString());
				actionExecutedContext.HttpContext.Response.Headers.Add("Pragma", "no-cache");
			}
		}
	}
}
