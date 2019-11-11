using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Model.Models.Users
{
    public abstract class User
    {
        public string Username { get; private set; }
        public User(string username)
        {
            Username = username;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Username == user.Username;
        }
    }
}
