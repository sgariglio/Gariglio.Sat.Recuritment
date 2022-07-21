﻿using Sat.Recruitment.Library.Account;
using Sat.Recruitment.Library.ValidatorEngine;

namespace Sat.Recruitment.Library.UserModel
{
    public interface IUserInputModel
    {
        string Address { get; set; }
        string Email { get; set; }
        string Money { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        string UserType { get; set; }
    }
}