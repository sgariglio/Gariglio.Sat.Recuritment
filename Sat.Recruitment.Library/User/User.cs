using Sat.Recruitment.Library.Account;
using Sat.Recruitment.Library.ValidatorEngine;

namespace Sat.Recruitment.Library.UserModel
{
    public class User : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string UserType { get; set; }
        public decimal Money { get; set; }

        public IAccounts account { get; set; }
        public IUserValidatorEngine validatorEngine { get; set; }
    }
}
