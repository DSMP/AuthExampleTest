using AuthExampleLibrary.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Models.Users
{
    public class Employee : User
    {
        public Employee(string username) : base(username)
        {
            UserClaims.Add(new Claim { Name = "ViewEmployee", Value = "true" }); 
        }

    }
}
