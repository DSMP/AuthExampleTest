using AuthExampleLibrary.Model.Attributes;
using AuthExampleLibrary.Model.Models;
using AuthExampleLibrary.Model.Models.Users;
using AuthExampleLibrary.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Services.IServices
{
    public interface IWorkerService
    {
        void EditEmployee(IAuthorize curUser, Employee employeeToEdit);
        EmployeeDetails ViewEmployee(IAuthorize curUser, Employee toShow);
        void ManageUser(IAuthorize curUser, User userToManage);
        void ManagePermission(IAuthorize curUser, User changeUserClaims);
    }
}
