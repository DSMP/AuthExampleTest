using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Model.Models.AnonymousUsers
{
    public class AnonymousUser : ILogin
    {
        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
