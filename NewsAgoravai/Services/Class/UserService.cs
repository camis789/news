using NewsAgoraVai.Models;
using NewsAgoraVai.Repository.Interface;
using NewsAgoraVai.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Services.Class
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool AddUser(User user)
        {
            if (userRepository.FindEmail(user.Email) == null)
            {
                userRepository.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Login(User user)
        {
            if (userRepository.Login(user.Email, user.Password) == null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public List<User> ListUsers()
        {
            return userRepository.ListUser();
        }
    }
}
