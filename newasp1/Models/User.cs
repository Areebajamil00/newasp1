namespace newasp1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [StringLength(50)]
        [Required(ErrorMessage = "This Field is Required")]
        public string FullName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "This Field is Required")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "This Field is Required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "This Field is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int id { get; set; }
    }
}
