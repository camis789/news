using NewsAgoraVai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Services.Interface
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        List<Comment> ListAllComments();
    }
}
