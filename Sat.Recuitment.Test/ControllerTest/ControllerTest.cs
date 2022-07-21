using Microsoft.AspNetCore.Mvc;
using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Library.Generic;
using Sat.Recruitment.Library.UserModel;
using Xunit;

namespace Sat.Recuitment.Test.ControllerTest
{
    public class ControllerTest
    {
        [Fact]
        public void Create_NormalUser()
        {

            // Arrange
            var expected = new Result()
            {
                Message = "User Created",
                IsSuccess = true
            };

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

            var userController = new UsersController();
            var result = userController.CreateUser(userModel);
            //var result = userController.CreateUser();
            var okResult = result as OkObjectResult;
            IResultCustom response = okResult.Value as IResultCustom;

            // Assert
            Assert.Equal(expected.IsSuccess, response.IsSuccess);
            Assert.Equal(expected.Message, response.Message);
        }

        [Fact]
        public void Create_DuplicatedByPhone()
        {
            // Arrange
            var expected = new Result()
            {
                Message = "The user is duplicated"
            };

            // Act
            var userModel = new UserInputModel()
            {
                Name = "Agustina",
                Email = "mike+test@gmail.com",
                Address = "Garay y Otra Calle",
                Phone = "+5491154762312",
                UserType  = "Normal",
                Money= "124",
            };

            var userController = new UsersController();
            var result = userController.CreateUser(userModel);
            var okResult = result as OkObjectResult;
            IResultCustom response = okResult.Value as IResultCustom;

            // Assert
            Assert.Equal(expected.IsSuccess==false, response.IsSuccess==false);
            Assert.Equal(expected.Message, response.Message);
        }

        [Fact]
        public void Create_Duplicated_ByNameAndress()
        {
            // Arrange
            var expected = new Result()
            {
                Message = "The user is duplicated"
            };

            // Act
            var userModel = new UserInputModel()
            {
                Name = "Agustina",
                Email = "mike+test@gmail.com",
                Address = "Garay y Otra Calle",
                Phone = "+5491154762312",
                UserType  = "Normal",
                Money= "124",
            };

            var userController = new UsersController();
            var result = userController.CreateUser(userModel);
            //var result = userController.CreateUser();
            var okResult = result as OkObjectResult;
            IResultCustom response = okResult.Value as IResultCustom;

            // Assert
            Assert.Equal(expected.IsSuccess==false, response.IsSuccess==false);
        }

        [Fact]
        public void Create_ErrorByNullName()
        {
            // Arrange
            var expected = new Result()
            {
                Message="The name is required"
            };

            // Act
            var userModel = new UserInputModel()
            {
                Name = "",
                Email = "mike+test@gmail.com",
                Address = "Garay y Otra Calle",
                Phone = "+5491154762312",
                UserType  = "Normal",
                Money= "124",
            };

            var userController = new UsersController();
            var result = userController.CreateUser(userModel);
            var okResult = result as OkObjectResult;
            IResultCustom response = okResult.Value as IResultCustom;

            // Assert
            Assert.Equal(expected.IsSuccess==false, response.IsSuccess==false);
            Assert.Equal(expected.Message, response.Message);
        }
    }
}
