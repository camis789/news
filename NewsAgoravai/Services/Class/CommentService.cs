using NewsAgoraVai.Models;
using NewsAgoraVai.Repository.Interface;
using NewsAgoraVai.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Services.Class
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;
    private readonly INewsRepository newsRepository;

    public CommentService(ICommentRepository commentRepository, INewsRepository newsRepository)
    {
        this.commentRepository = commentRepository;
        this.newsRepository = newsRepository;
    }

        public void AddComment(Comment comment)
        {
            
            commentRepository.Add(comment);
        }


        public List<Comment> ListAllComments()
    {
        return commentRepository.ListComments();
    }
}
    


    }

