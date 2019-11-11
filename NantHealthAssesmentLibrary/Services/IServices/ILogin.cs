using NantHealthAssesmentLibrary.Model.Models.AnonymousUsers;
using NantHealthAssesmentLibrary.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Service.IServices
{
    public interface ILogin
    {
        User Authenticate(AnonymousUser user);
    }
}
