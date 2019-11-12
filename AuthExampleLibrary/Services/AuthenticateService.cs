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
        private AuthExampleContext _context;

        public AuthenticateService(AuthExampleContext dbContext)
        {
            _context = dbContext;
        }

        public User Authenticate(AnonymousUser user)
        {
            var registeredUser = _context.Users.Where(u => u.Username.Equals(user.Username) && u.Password.Equals(user.Password)).FirstOrDefault();
            if (registeredUser == null)
            {
                return null;
            }
            return new Employee(registeredUser.Username);
        }
    }
}
