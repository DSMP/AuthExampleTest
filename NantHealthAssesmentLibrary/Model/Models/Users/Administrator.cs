﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NantHealthAssesmentLibrary.Model.Models.Users
{
    public class Administrator : User, IManagePermission, IManageUser
    {
    }
}