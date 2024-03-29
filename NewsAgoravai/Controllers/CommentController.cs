﻿using System;
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
    public class CommentController : Controller
    {
        private readonly ICommentService CommentService;

        public CommentController(ICommentService commentService)
        {
            this.CommentService = commentService;
        }

        // GET: api/values
        [HttpGet]
        public List<Comment> Get()
        {
            return CommentService.ListAllComments();
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<bool> Post([FromBody]Comment comment)
        {
            if (comment != null)
            {

                CommentService.AddComment(comment);
                return true;
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
