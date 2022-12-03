using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newasp1.Models
{
    public class CommentRepositry
    {
        Model1 context = new Model1();

        public IQueryable GetAll()
        {
            return context.Comments.OrderBy(x => x.timestamp);
        }

        public Comment AddComment(Comment comment)
        {
            var _comment = new Comment()
            {
              //  insId = comment.insId,
                parentid=comment.parentid,
                text = comment.text,
                name = comment.name,
                timestamp = DateTime.Now
            };

            context.Comments.Add(_comment);
            context.SaveChanges();
            return context.Comments.Where(x => x.Commentid == _comment.Commentid)
                    .Select(x => new Comment
                    {
                        Commentid = x.Commentid,
                        text = x.text,
                        parentid = x.parentid,
                        timestamp= x.timestamp,
                        name = x.name

                    }).FirstOrDefault();
        }
    }
}