using AuthExampleLibrary.Model.Models.AnonymousUsers;
using AuthExampleLibrary.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Service.IServices
{
    public interface ILogin
    {
        User Authenticate(AnonymousUser user);
    }
}
