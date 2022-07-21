using Microsoft.AspNetCore.Mvc;
using Sat.Recruitment.Library.Factory;
using Sat.Recruitment.Library.UserModel;

namespace Sat.Recruitment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class UsersController : ControllerBase
    {
        [HttpPost]
        [Route("/create-user")]
        public IActionResult CreateUser(IUserInputModel model)
        {
            var response = FactoryResponse.responseCreate();
            var newUser = Factory.UserInit(model);

            //input errors
            if (newUser.validatorEngine.ValidateErrors().IsSuccess==false) return Ok(newUser.validatorEngine.ValidateErrors());

            //duplicated
            var isDuplicated = newUser.validatorEngine.DuplicatedVerify();
            if (!isDuplicated)
            {
                response.IsSuccess=true;
                response.Message="User Created";
            }
            else
            {
                response.Message="The user is duplicated";
            }
            return Ok(response);
        }
    }

}
