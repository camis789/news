using NewsAgoraVai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Services.Interface
{
    public interface INewsService
    {
        bool AddNews(News news);
        List<News> ListAllNewss();
    }
}
