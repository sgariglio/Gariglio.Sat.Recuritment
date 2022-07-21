using Sat.Recruitment.Library.UserModel;
using System.Reflection;

namespace Sat.Recruitment.Library.Repository
{
    public class RepositoryEngine : IRepository
    {
        public List<IUser> UserList(string filePath)
        {
            List<IUser> users = new List<IUser>();

            var path = Directory.GetCurrentDirectory() + filePath;
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);
                while (reader.Peek() >= 0)
                {
                    var line = reader.ReadLineAsync().Result;
                    var user = new User
                    {
                        Name = line.Split(',')[0].ToString(),
                        Email = line.Split(',')[1].ToString(),
                        Phone = line.Split(',')[2].ToString(),
                        Address = line.Split(',')[3].ToString(),
                        UserType = line.Split(',')[4].ToString(),
                        Money = decimal.Parse(line.Split(',')[5].ToString()),
                    };
                    users.Add(user);
                }
                reader.Close();
            }
            catch (Exception)
            {

            }

            return users;
        }
    }
}
