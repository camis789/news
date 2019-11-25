using NewsAgoraVai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Repository.Interface
{
     public interface ICommentRepository
    {
        void Add(Comment comment);
       // Comment FindById(int Id);
        List<Comment> ListComments();
    }
}
