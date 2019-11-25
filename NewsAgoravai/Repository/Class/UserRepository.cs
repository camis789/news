using NewsAgoraVai.Contexts;
using NewsAgoraVai.Models;
using NewsAgoraVai.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Repository.Class
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContextProducts _context;

        public UserRepository(DBContextProducts ctx)
        {
            _context = ctx;
        }

        public void Add(User user)
        {
            user.DateCreate = DateTime.Now;
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User Login(string email, string password)
        {
            return _context.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }


        public User FindEmail(string email)
        {
            return _context.Users.Where(x => x.Email == email).FirstOrDefault();
        }

        public List<User> ListUser()
        {
            return _context.Users.ToList();
        }
    }
}
