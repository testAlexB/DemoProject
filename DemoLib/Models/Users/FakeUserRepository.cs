using System.Collections.Generic;

namespace DemoLib.Models
{
    public class FakeUserRepository : IUsersRepository
    {
        private List<User> allUsers_ = new List<User>() {
                new User { Login = "a.boikov", Password = "1234", Role = UserRole.Admin},
                new User { Login = "s.gavrilchenko", Password = "12345", Role = UserRole.Manager},
                new User { Login = "zzz@mail.ru", Password = ""}};

        public List<User> GetAllUsers()
        {
            return allUsers_;
        }

        public User GetUserByLogin(string login)
        {
            foreach (User user in allUsers_)
            {
                if(user.Login == login)
                {
                    return user;
                }
            }
                
            return null;
        }
    }
}
