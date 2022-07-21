using Sat.Recruitment.Library.UserModel;

namespace Sat.Recruitment.Library.Repository
{
    public interface IRepository
    {
        List<IUser> UserList(string filePath);
    }
}