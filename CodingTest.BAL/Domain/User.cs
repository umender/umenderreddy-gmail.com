using CodingTest.BAL.Repositories;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace CodingTest.BAL.Domain
{
  public  class User :IUser
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        private List<User> _users;
        private readonly ILogger<User> _logger;
        public User()
        {
         

        }
        public User(ILogger<User> logger)
        {
            _logger = logger;
            _users = new List<User>
        {
            new User { Id = 1, FirstName = "READER", LastName = "User", Username = "READER", Password = "test",Role="READER" },
              new User { Id = 2, FirstName = "CONTRIBUTOR", LastName = "User", Username = "CONTRIBUTOR", Password = "test",Role="CONTRIBUTOR" },
                new User { Id = 3, FirstName = "FULLACCESS", LastName = "User", Username = "FULLACCESS", Password = "test",Role="FULLACCESS" }
        };
        }
        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password.ToLower() == password.ToLower());

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("UmenderReddyAbbatiAttending CodingTest");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Role, user.Role.ToString()),
                     new Claim(ClaimTypes.Name, user.LastName.ToString())
                }),
             
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            

            return user;
        }
    }
}
