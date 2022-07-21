using Sat.Recruitment.Library.Factory;
using Sat.Recruitment.Library.Generic;
using Sat.Recruitment.Library.UserModel;

namespace Sat.Recruitment.Library.ValidatorEngine
{
    public class UserValidatorEngine : IUserValidatorEngine
    {
        private IUser user;
        private List<IUser> usersInRepository;
        private string EmailNormalized { get; set; }

        public UserValidatorEngine(IUser user, List<IUser> users)
        {
            this.user=user;
            usersInRepository=users;
            EmailNormalized=EmailNormalizer();
        }

        public bool DuplicatedVerify()
        {
            var isDuplicated = false;
            var userDuplicated = usersInRepository.Where(w =>
                w.Email.ToLower()==EmailNormalized.ToLower() || w.Phone==user.Phone ||
                w.Name.ToLower()==user.Name.ToLower() && w.Address.ToLower()==user.Address.ToLower())
                .FirstOrDefault();

            if (userDuplicated!=null) isDuplicated = true;
            return isDuplicated;
        }

        private string EmailNormalizer()
        {
            //Normalize email
            var aux = user.Email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);
            aux[0] = atIndex< 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);
            return string.Join("@", new string[] { aux[0], aux[1] });
        }

        public IResultCustom ValidateErrors()
        {
            var result = FactoryResponse.responseCreate();
            if (user.Name == null || user.Name.Length==0)
                //Validate if Name is null
                result.Message= "The name is required";
            if (user.Email == null  || user.Email.Length==0)
                //Validate if Email is null
                result.Message = result.Message + " The email is required";
            if (user.Address == null   || user.Address.Length==0)
                //Validate if Address is null
                result.Message = result.Message + " The address is required";
            if (user.UserType == null || user.UserType.Length==0)
                //Validate if Phone is null
                result.Message = result.Message + " The phone is required";
            if (result.Message.Length==0) result.IsSuccess=true;
            return result;
        }
    }
}
