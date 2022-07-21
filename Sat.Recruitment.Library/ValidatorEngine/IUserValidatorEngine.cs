using Sat.Recruitment.Library.Generic;

namespace Sat.Recruitment.Library.ValidatorEngine
{
    public interface IUserValidatorEngine
    {
        bool DuplicatedVerify();
        IResultCustom ValidateErrors();
    }
}