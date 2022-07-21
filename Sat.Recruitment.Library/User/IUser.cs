using Sat.Recruitment.Library.Account;
using Sat.Recruitment.Library.ValidatorEngine;

namespace Sat.Recruitment.Library.UserModel
{
    public interface IUser
    {
        string Address { get; set; }
        string Email { get; set; }
        decimal Money { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        string UserType { get; set; }

        public IAccounts account { get; set; }
        public IUserValidatorEngine validatorEngine { get; set; }
    }
}