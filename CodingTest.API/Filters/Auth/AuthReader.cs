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

namespace CodingTest.API.Filters.Auth
{
    public class AuthReader : Attribute, IAuthorizationFilter
    {


        public void OnAuthorization(AuthorizationFilterContext context)
        {

            if (!TryRetrieveToken(context.HttpContext.Request, out StringValues token))
            {
                context.Result = new UnauthorizedResult();
            }
            

            
        }
        private static bool TryRetrieveToken(HttpRequest request, out StringValues token)
        {


            //IEnumerable<string> authzHeaders;
            if (!request.Headers.TryGetValue("Authorization", out token) || token.Count() > 1)
            {
                return false;
            }
            {

                var key = Encoding.ASCII.GetBytes("UmenderReddyAbbatiAttending CodingTest");

                var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes("UmenderReddyAbbatiAttending CodingTest"));

                SecurityToken securityToken;
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                TokenValidationParameters validationParameters = new TokenValidationParameters()
                {

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
                string s= token.ToString().Replace("Bearer ", string.Empty);

                IPrincipal principal;
                 // token validation
                    principal = handler.ValidateToken(s, validationParameters, out securityToken);
                // Reading the "verificationKey" claim value:
                var vk = principal.IsInRole("READER");
              
                return vk;
            }
        }
        public bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
        {
            if (expires != null)
            {
                if (DateTime.UtcNow < expires) return true;
            }
            return false;
        }
    }
}
