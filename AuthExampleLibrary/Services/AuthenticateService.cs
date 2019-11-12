using System;
using System.Linq;
using AuthExampleLibrary.Model.Entities;
using AuthExampleLibrary.Model.Models.AnonymousUsers;
using AuthExampleLibrary.Model.Models.Users;
using AuthExampleLibrary.Service.IServices;
using Microsoft.EntityFrameworkCore;

namespace AuthExampleLibrary.Services
{
    public class AuthenticateService : ILogin
    {
        private DbContextOptions<AuthExampleContext> _options;

        public AuthenticateService()
        {
            _options = new DbContextOptions<AuthExampleContext>();
        }

        public AuthenticateService(DbContextOptions<AuthExampleContext> options)
        {
            _options = options;
        }

        public User Authenticate(AnonymousUser user)
        {
            using (var db = new AuthExampleContext(_options))
            {
                var registeredUser = db.Users.Where(u => u.Username.Equals(user.Username) && u.Password.Equals(user.Password)).FirstOrDefault();
                if (registeredUser == null)
                {
                    return null;
                }
                return new Employee(registeredUser.Username);
            }
        }
    }
}
