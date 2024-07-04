using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos
{
    public class UserService
    {
        public IUserRepository userRepository { get; }

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            this.userRepository.AddUser(user);
        }
    }

    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {

        }
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
