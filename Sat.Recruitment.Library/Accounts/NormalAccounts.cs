using Sat.Recruitment.Library.UserModel;

namespace Sat.Recruitment.Library.Account
{
    public class NormalAccounts :IAccounts
    {
        public void Salary(IUser user)
        {
            decimal money =user.Money;
            if (money >= 100)
            {
                var percentage = Convert.ToDecimal(0.12);
                //If new user is normal and has more than USD100
                var gif = money * percentage;
                money = money + gif;
            }
            else if (money < 100)
            {
                if (money > 10)
                {
                    var percentage = Convert.ToDecimal(0.8);
                    var gif = money * percentage;
                    money= money + gif;
                }
            }
            user.Money=money;
        }
    }
}
