using CodingTest.API.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;

namespace CodingTest.API.Filters.Auth
{
    public class AuthFullAccess : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string[] roles = { "FULLACCESS" };
            if (!ValidateAuthHeaders.TryRetrieveToken(context.HttpContext.Request, out StringValues token, roles))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
