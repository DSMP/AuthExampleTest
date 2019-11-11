using NantHealthAssesmentLibrary.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Service.IServices
{
    interface IManageUserService : IAuthorize
    {
        void ManageUser(IManageUser manageUser, User userToManage);
    }
}
