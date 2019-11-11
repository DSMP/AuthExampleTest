using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Model.Models.AnonymousUsers
{
    public interface IAuthenticate
    {
        void Login(string username, string password);
    }
}
