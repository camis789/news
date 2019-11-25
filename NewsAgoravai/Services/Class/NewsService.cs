using NewsAgoraVai.Models;
using NewsAgoraVai.Services.Interface;
using NewsAgoraVai.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Services.Class
{
    public class NewsService : INewsService
    {
        private readonly ICommentRepository commentRepository;

        private readonly INewsRepository newsRepository;

    public NewsService(INewsRepository newsRepository)
    {
        this.newsRepository = newsRepository;
    }

    public List<News> ListAllNewss()
    {
        return newsRepository.ListNewss();
    }

    public bool AddNews(News news)
    {
        if (newsRepository.FindByName(news.Name) == null)
        {
           
            newsRepository.Add(news);
            return true;
        }
        else
        {
            return false;
        }


    }

}
    

    }
