using System.Collections.Generic;

namespace DemoLib.Models
{
    public interface IUsersRepository
    {
        List<User> GetAllUsers();

        User GetUserByLogin(string login);
    }
}
