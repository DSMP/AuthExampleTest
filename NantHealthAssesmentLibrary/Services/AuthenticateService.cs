using System;
using System.Linq;
using NantHealthAssesmentLibrary.Model.Entities;
using NantHealthAssesmentLibrary.Model.Models.AnonymousUsers;
using NantHealthAssesmentLibrary.Model.Models.Users;
using NantHealthAssesmentLibrary.Service.IServices;

namespace NantHealthAssesmentLibrary.Services
{
    public class AuthenticateService : ILogin
    {
        public User Authenticate(AnonymousUser user)
        {
            using (var db = new NantHealthAssesContext())
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
