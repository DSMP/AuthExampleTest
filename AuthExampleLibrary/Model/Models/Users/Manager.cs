using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Models.Users
{
    public class Manager : User
    {
        public Manager(string username) : base(username)
        {
            UserClaims.Add(new Claim { Name = "ViewEmployee", Value = "true" });
            UserClaims.Add(new Claim { Name = "EditEmployee", Value = "true" });
        }
    }
}
