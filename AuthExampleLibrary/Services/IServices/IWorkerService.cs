using AuthExampleLibrary.Model.Models.Users;
using AuthExampleLibrary.Model.Models.Users.Permissions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Services.IServices
{
    interface IWorkerService
    {
        void EditEmployee(IEditEmployee curUser, Employee employeeToEdit);
        Employee ViewEmployee(IViewEmployee curUser, Employee toShow);
        void ManageUser(IManageUser curUser, User userToManage);
        void ManagePermission(IManagePermissions curUser, User changeUserClaims);
    }
}
