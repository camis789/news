using NewsAgoraVai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Repository.Interface
{
        public interface IUserRepository
    {
        void Add(User user);
        User FindEmail(string email);
        List<User> ListUser();
        User Login(string email, string password);
    }
}
