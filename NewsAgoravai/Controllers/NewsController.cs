using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsAgoraVai.Models;
using NewsAgoraVai.Services.Class;
using NewsAgoraVai.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewsAgoraVai.Controllers
{
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        private readonly INewsService NewsService;

        public NewsController(INewsService NewsService)
        {
            this.NewsService = NewsService;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("list")]
        public List<News> GetNews()
        {
            return NewsService.ListAllNewss();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<bool> Post([FromBody]News news)
        {
            if (!string.IsNullOrWhiteSpace(news.Name))
            {
                
                var result = NewsService.AddNews(news);
                
                return result;
            }
            else
            {
                return BadRequest();
            }

        }
       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
