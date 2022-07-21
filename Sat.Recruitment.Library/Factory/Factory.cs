using Sat.Recruitment.Library.Account;
using Sat.Recruitment.Library.Repository;
using Sat.Recruitment.Library.UserModel;
using Sat.Recruitment.Library.ValidatorEngine;

namespace Sat.Recruitment.Library.Factory
{
    public class Factory
    {
        public static User userCreate()
        {
            return new User();
        }

        public static List<IUser> users()
        {
            var filePath = "/Files/Users.txt";
            var repository = new RepositoryEngine();
            return repository.UserList(filePath);
        }

        public static IUserValidatorEngine ValidatorEngineCreate(IUser user) {
            return new UserValidatorEngine(user,Factory.users());
        }

        public static IUser UserInit(IUserInputModel reference)
        {
            var user = new User();
            user.Name=reference.Name;
            user.Email=reference.Email;
            user.Address=reference.Address;
            user.Phone=reference.Phone;
            user.UserType=reference.UserType;
            try
            {
                user.Money=Convert.ToDecimal(reference.Money);
            }
            catch (Exception)
            {
            }
            
            switch (reference.UserType)
            {
                case "Normal":
                    user.account=new NormalAccounts();
                    break;
                case "SuperUser":
                    user.account=new SuperUserAccounts();
                    break;
                case "Premium":
                    user.account=new PremiumAccounts();
                    break;
            }

            user.account.Salary(user);
            user.validatorEngine=ValidatorEngineCreate(user);

            return user;
        }
    }
}
