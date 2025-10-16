using System.Collections.Generic;

namespace DemoLib.Models
{
    public class UsersModel
    {
        private IUsersRepository usersRepository_;

        public UsersModel()
        {
            usersRepository_ = new FakeUserRepository();
        }

        public List<string> GetAllLogins()
        {
            List<User> allUsers = usersRepository_.GetAllUsers();

            List<string> logins = new List<string>();
            foreach (User user in allUsers)
            {
                logins.Add(user.Login);
            }

            return logins;
        }

        public bool Authorization(string login, string password)
        {

        }
    }
}
