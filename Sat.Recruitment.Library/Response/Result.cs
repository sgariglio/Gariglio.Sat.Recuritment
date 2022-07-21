using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Library.Generic
{
    public class Result : IResultCustom
    {
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; } = "";
    }
}
