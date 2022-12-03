using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity.Spatial;
namespace newasp1.Models
{
    [Table("comment")]
    public class Comment
    {
        [Key]
        public int Commentid { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public int parentid { get; set; }

        public DateTime timestamp { get; set; }
       
        //public int? stdid { get; set; }
        //[ForeignKey("stdid")]
        //public virtual User StdId { get; set; }
       // public List<Comment> CommentList { get; internal set; }
    }
}