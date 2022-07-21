using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Library.UserModel
{
    public class UserInputModel : IUserInputModel
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string Money { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string UserType { get; set; }
    }
}
