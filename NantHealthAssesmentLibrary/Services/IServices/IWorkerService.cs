using NantHealthAssesmentLibrary.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Services.IServices
{
    public interface IWorkerService
    {
        void EditEmployee(User curUser, Employee employeeToEdit);
        Employee ViewEmployee(User curUser, Employee toShow);
        void ManageUser(User curUser, User userToManage);
        void ManagePermission(User curUser, User changeUserClaims);
    }
}
