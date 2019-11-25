using NewsAgoraVai.Contexts;
using NewsAgoraVai.Models;
using NewsAgoraVai.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Repository.Class
{
    public class NewsRepository : INewsRepository
    {
        
        private readonly DBContextProducts _context;

        public NewsRepository(DBContextProducts ctx)
        {
            _context = ctx;
        }

        public void Add(News news)
        {
            _context.Newss.Add(news);
            _context.SaveChanges();
        }

        public News FindByName(string name)
        {
            return _context.Newss.Where(x => x.Name == name).FirstOrDefault();
        }

      /*  public News FindByNewCode(int newcode)
        {
            return _context.Newss.Where(x => x.NewCode == newcode).FirstOrDefault();
        }
*/
        public List<News> ListNewss()
        {
            return _context.Newss.ToList();
        }
    }
}

