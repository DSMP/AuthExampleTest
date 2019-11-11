using NantHealthAssesmentLibrary.Model.Models;
using NantHealthAssesmentLibrary.Model.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Service.IServices
{
    //Excercise 2
    public interface IAuthorize
    {
        bool Autorize(User user, Claim userClaims);
    }
}
