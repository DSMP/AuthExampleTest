using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Model.Models.Users
{
    public abstract class User
    {
        public string Username { get; private set; }
        public List<Claim> UserClaims { get; private set; }
        public User(string username) : this()
        {
            Username = username;
        }

        protected User()
        {
            UserClaims = new List<Claim>();
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Username == user.Username;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Username, UserClaims);
        }
    }
}
