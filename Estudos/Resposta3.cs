using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    public class UserService
    {

    }

    public class UserRepository :IUserRepository
    {

    }

    public class User
    {
        public string? Name { get; set; }
    }

    public interface IUserRepository
    {
        void AddUser(User user);
    }
}
