using Sat.Recruitment.Library.UserModel;

namespace Sat.Recruitment.Library.Account
{
    public class PremiumAccounts:IAccounts
    {
        public void Salary(IUser user)
        {
            decimal money = user.Money;
            if (money > 100)
            {
                var gif = money * 2;
                money= money + gif;
            }
            user.Money=money;
        }
    }
}
