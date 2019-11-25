using NewsAgoraVai.Contexts;
using NewsAgoraVai.Models;
using NewsAgoraVai.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAgoraVai.Repository.Class
{
    public class CommentRepository : ICommentRepository
    {
        private readonly DBContextProducts _context;

    public CommentRepository(DBContextProducts ctx)
    {
        _context = ctx;
    }

    public void Add(Comment comment)
    {
        _context.Comments.Add(comment);
        _context.SaveChanges();
    }

   /* public Comment FindById(int Id)
    {
            return _context.Comments.Where(x => x.Id == Id).FirstOrDefault();
        }
*/
    public List<Comment> ListComments()
    {
        return _context.Comments.ToList();
    }
}
    
    }

