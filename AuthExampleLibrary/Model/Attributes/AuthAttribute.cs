using AuthExampleLibrary.Model.Models;
using AuthExampleLibrary.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthExampleLibrary.Model.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class AuthAttribute : Attribute
    {
        public AuthAttribute(IAuthorize authorize, Claim claimsNeeded)
        {
            if (!authorize.Authorize(claimsNeeded))
            {
                throw new UnauthorizedAccessException();
            }
        }
    }
}
