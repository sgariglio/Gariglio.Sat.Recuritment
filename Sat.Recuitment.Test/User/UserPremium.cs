using Sat.Recruitment.Library.Factory;
using Sat.Recruitment.Library.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Sat.Recuitment.Test.User
{
    public class UserPremium
    {
       
        [Fact]
        public void UserInit_MoneyMoreThan100()
        {
            // Arrange
            decimal expected = 3000;

            // Act
            var userModel = new UserInputModel()
            {
                Name = "Sebatian",
                Email = "gariglio+test@gmail.com",
                Address = "Colon 744",
                Phone = "+541144457408",
                UserType  = "Premium",
                Money= "1000",
            };
            var user = Factory.UserInit(userModel);

            // Assert
            Assert.Equal(expected, user.Money);
        }

        [Fact]
        public void UserInit_MoneyLessThan100()
        {
            // Arrange
            decimal expected = 100;

            // Act
            var userModel = new UserInputModel()
            {
                Name = "Sebatian",
                Email = "gariglio+test@gmail.com",
                Address = "Colon 744",
                Phone = "+541144457408",
                UserType  = "Premium",
                Money= "100",
            };
            var user = Factory.UserInit(userModel);

            // Assert
            Assert.Equal(expected, user.Money);
        }
    }
}
