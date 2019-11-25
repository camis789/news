using Microsoft.EntityFrameworkCore;
using NewsAgoraVai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Contexts
{
    public class DBContextProducts : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<News> Newss { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DBContextProducts(DbContextOptions<DBContextProducts> options) : base(options)
        {

        }
    }
}
