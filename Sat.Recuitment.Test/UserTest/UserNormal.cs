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
    public class UserNormal
    {
        private readonly ITestOutputHelper output;
        public UserNormal(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void UserInit_MoneyMore100()
        {
            // Arrange
            decimal expected = 112;

            // Act
            var userModel = new UserInputModel()
            {
                Name = "Sebatian",
                Email = "gariglio+test@gmail.com",
                Address = "Colon 744",
                Phone = "+541144457408",
                UserType  = "Normal",
                Money= "100",
            };
            var user = Factory.UserInit(userModel);

            // Assert
            Assert.Equal(expected, user.Money);
        }

        [Fact]
        public void UserInit_Money1()
        {
            // Arrange
            decimal expected = 1;

            // Act
            var userModel = new UserInputModel()
            {
                Name = "Sebatian",
                Email = "gariglio+test@gmail.com",
                Address = "Colon 744",
                Phone = "+541144457408",
                UserType  = "Normal",
                Money= "1",
            };
            var user = Factory.UserInit(userModel);

            // Assert
            Assert.Equal(expected, user.Money);
        }

        [Fact]
        public void UserInit_MoneyMore10Less100()
        {
            // Arrange
            decimal expected = 36;

            // Act
            var userModel = new UserInputModel()
            {
                Name = "Sebatian",
                Email = "gariglio+test@gmail.com",
                Address = "Colon 744",
                Phone = "+541144457408",
                UserType  = "Normal",
                Money= "20",
            };
            var user = Factory.UserInit(userModel);

            // Assert
            Assert.Equal(expected, user.Money);
        }
    }
}
