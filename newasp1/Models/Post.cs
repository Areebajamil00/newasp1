namespace newasp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        public int Postid { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "This Field is Required")]
        public string PostTitle { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "This Field is Required")]
        public string PostDescription { get; set; }
        public DateTime Date { get; set; }
        public int upvote { get; set; }
        public int downvote { get; set; }
        public int? insId { get; set; }
        [ForeignKey("insId")]
        public virtual InstructorLogins ins { get; set; }
    }
}
