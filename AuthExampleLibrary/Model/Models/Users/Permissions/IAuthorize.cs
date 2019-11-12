using AuthExampleLibrary.Model.Models;
using AuthExampleLibrary.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Models.Users.Permissions
{
    //Excercise 2
    public interface IAuthorize
    {
        bool Autorize();
    }
}
