using NantHealthAssesment.Db;
using NantHealthAssesmentLibrary.Model.Entities;
using NantHealthAssesmentLibrary.Model.Models.AnonymousUsers;
using NantHealthAssesmentLibrary.Model.Models.Users;
using NantHealthAssesmentLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitTestProject.ServiceTests
{
    public class AuthenticateServiceTests
    {
        private readonly AuthenticateService _authService;

        public AuthenticateServiceTests()
        {
            _authService = new AuthenticateService();
        }
        [Fact]
        public void Authenticate()
        {
            using (var db = new MainNantHealthAssesContext())
            {
                if (!db.Users.Where(u => u.Username.Equals("user1")).Any())
                {
                    db.Users.Add(new UserAuthenticationsEntity { Username = "user1", Password = "pass1" });
                    db.SaveChanges();
                }
            }
            var result = _authService.Authenticate(new AnonymousUser("user1", "pass1" ));
            Assert.Equal(new Employee("user1"), result);
        }
        [Fact]
        public void NotAuthenticate()
        {
            var result = _authService.Authenticate(new AnonymousUser("userNotExists", "pass1"));
            Assert.Null(result);
        }
    }
}
