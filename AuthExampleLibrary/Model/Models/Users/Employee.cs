using AuthExampleLibrary.Model.Models.Users.Permissions;
using AuthExampleLibrary.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Models.Users
{
    public class Employee : User, IViewEmployee
    {
        public Employee(string username) : base(username)
        {
            UserClaims.Add(new Claim { Name = "ViewEmployee", Value = "true" }); 
        }

    }
}
