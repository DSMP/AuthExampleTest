using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Models.AnonymousUsers
{
    public class AnonymousUser
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public AnonymousUser(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
