using Sat.Recruitment.Library.Generic;

namespace Sat.Recruitment.Library.Factory
{
    public class FactoryResponse
    {
        public static IResultCustom responseCreate()
        {
            return new Result();
        }
    }
}
