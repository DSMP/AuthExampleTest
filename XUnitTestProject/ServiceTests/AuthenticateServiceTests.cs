using AuthExample.Db;
using AuthExampleLibrary.Model.Entities;
using AuthExampleLibrary.Model.Models.AnonymousUsers;
using AuthExampleLibrary.Model.Models.Users;
using AuthExampleLibrary.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitTestProject.ServiceTests
{
    public class AuthenticateServiceTests
    {
        private readonly DbContextOptions<AuthExampleContext> _options;

        public AuthenticateServiceTests()
        {
            _options = new DbContextOptionsBuilder<AuthExampleContext>().UseInMemoryDatabase("UserWasAuthenticate").Options;
        }
        [Fact]
        public void Authenticate()
        {
            User result = null; 
            using (var db = new MainAuthExampleContext(_options))
            {
                if (!db.Users.Where(u => u.Username.Equals("user1")).Any())
                {
                    db.Users.Add(new UserAuthenticationsEntity { Username = "user1", Password = "pass1" });
                    db.SaveChanges();
                }

                var authService = new AuthenticateService(db);
                result = authService.Authenticate(new AnonymousUser("user1", "pass1"));
            }
            Assert.Equal(new Employee("user1"), result);
        }
        [Fact]
        public void NotAuthenticate()
        {
            using (var db = new MainAuthExampleContext(_options))
            {
                var authService = new AuthenticateService(db);
                var result = authService.Authenticate(new AnonymousUser("userNotExists", "pass1"));
                Assert.Null(result); 
            }
        }
    }
}
