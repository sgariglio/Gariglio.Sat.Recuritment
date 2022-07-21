using Sat.Recruitment.Library.UserModel;

namespace Sat.Recruitment.Library.Account
{
    public class SuperUserAccounts : IAccounts
    {
        public void Salary(IUser user)
        {
            decimal money =user.Money;
            if (money > 100)
            {
                var percentage = Convert.ToDecimal(0.20);
                var gif = money * percentage;
                money= money + gif;
            }
            user.Money=money;
        }
    }
}
