using NantHealthAssesmentLibrary.Model.Models;
using NantHealthAssesmentLibrary.Model.Models.Users;
using NantHealthAssesmentLibrary.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitTestProject.ServiceTests
{
    public class AutorizeTestimpl : IAuthorize
    {
        public bool Autorize(User user, Claim claimNedded)
        {
            return user.UserClaims.Any(c => c.Name.Equals(claimNedded) && c.Value.Equals(claimNedded.Value));
        }
    }
}
