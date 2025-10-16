using System.Collections.Generic;

namespace DemoLib.Models
{
    public class FakeUserRepository : IUsersRepository
    {
        public List<User> GetAllUsers()
        {
            return new List<User>() {
                new User { Login = "a.boikov", Password = "1234"},
                new User { Login = "s.gavrilchenko", Password = "12345"},
                new User { Login = "zzz@mail.ru", Password = ""}};
        }
    }
}
