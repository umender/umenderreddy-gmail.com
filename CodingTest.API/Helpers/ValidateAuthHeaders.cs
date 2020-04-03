using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.API.Helpers
{
    public static class ValidateAuthHeaders
    {
        public static bool TryRetrieveToken(HttpRequest request, out StringValues token,string [] roles)
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
                string s = token.ToString().Replace("Bearer ", string.Empty);

                IPrincipal principal;
                // token validation
                principal = handler.ValidateToken(s, validationParameters, out securityToken);
                // Reading the "verificationKey" claim value:
                bool isAccess = false;
                foreach (string str in roles)
                {
                    isAccess = principal.IsInRole(str);
                    if (isAccess)
                        return true;
                    else
                        continue;
                }

                return isAccess;
            }
        }

    }
}
