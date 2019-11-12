using System;
using System.Linq;
using AuthExampleLibrary.Model.Entities;
using AuthExampleLibrary.Model.Models.AnonymousUsers;
using AuthExampleLibrary.Model.Models.Users;
using AuthExampleLibrary.Service.IServices;

namespace AuthExampleLibrary.Services
{
    public class AuthenticateService : ILogin
    {
        public User Authenticate(AnonymousUser user)
        {
            using (var db = new AuthExampleContext())
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
