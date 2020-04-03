using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodingTest.API.Helpers;

namespace CodingTest.API.Filters.Auth
{
    public class AuthReader : Attribute, IAuthorizationFilter
    {


        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string[] roles = { "READER", "CONTRIBUTOR", "FULLACCESS" };
            if (!ValidateAuthHeaders.TryRetrieveToken(context.HttpContext.Request, out StringValues token, roles ))
            {
                context.Result = new UnauthorizedResult();
            }          
        }
     
      
    }
}
