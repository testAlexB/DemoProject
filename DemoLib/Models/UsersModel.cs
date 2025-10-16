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

        }
    }
}
