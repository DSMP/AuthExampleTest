using NantHealthAssesmentLibrary.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Model.Models.Users
{
    public class Employee : User
    {
        public Employee(string username) : base(username)
        {
        }

    }
}
