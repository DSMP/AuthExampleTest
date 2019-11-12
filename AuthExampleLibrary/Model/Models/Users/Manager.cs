using AuthExampleLibrary.Model.Models.Users.Permissions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Models.Users
{
    public class Manager : User, IEditEmployee, IViewEmployee
    {
        public Manager(string username) : base(username)
        {
            UserClaims.Add(new Claim { Name = "ViewEmployee", Value = "true" });
            UserClaims.Add(new Claim { Name = "EditEmployee", Value = "true" });
        }

        public bool Autorize()
        {
            throw new NotImplementedException();
        }
    }
}
