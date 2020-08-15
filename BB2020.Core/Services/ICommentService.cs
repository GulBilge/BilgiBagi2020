using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BB2020.Core.Services
{
   public interface ICommentService
    {
        Task<IEnumerable<Comment>> GetComments();
        Task<Comment> GetCommentById(int id);
        Task<Comment> CreateComment(Comment comment);
        Task UpdateComment(Comment commentToBeUpdated, Comment comment);
        Task DeleteComment(Comment comment);
    }
}
