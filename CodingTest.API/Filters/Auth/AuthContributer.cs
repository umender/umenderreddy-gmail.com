using CodingTest.API.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.API.Filters
{
    public class AuthContributer: Attribute, IAuthorizationFilter
    {


        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string[] roles = { "FULLACCESS", "CONTRIBUTOR" };
            if (!ValidateAuthHeaders.TryRetrieveToken(context.HttpContext.Request, out StringValues token, roles))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
