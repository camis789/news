using NewsAgoraVai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Services.Interface
{
    public interface IUserService
    {
        bool Login(User user);
        bool AddUser(User user);
        List<User> ListUsers();
    }
}
