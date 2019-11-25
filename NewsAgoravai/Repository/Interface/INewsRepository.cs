using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsAgoraVai.Models;

namespace NewsAgoraVai.Repository.Interface
{
    public interface INewsRepository
    {
        void Add(News news);
        News FindByName(string name);
        //News FindByNewCode(int newcode);
        List<News> ListNewss();
    }
}
