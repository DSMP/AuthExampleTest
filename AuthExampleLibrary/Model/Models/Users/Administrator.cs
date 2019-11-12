using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Models.Users
{
    public class Administrator : User
    {
        public Administrator(string username) : base(username)
        {
            UserClaims.Add(new Claim { Name = "ManageUser", Value = "true" });
            UserClaims.Add(new Claim { Name = "ManagePermission", Value = "true" });
        }
    }
}
