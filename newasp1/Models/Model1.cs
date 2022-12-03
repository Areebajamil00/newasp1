using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace newasp1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<InstructorLogins> InstructorAccounts { get; set; }
        public virtual DbSet<InstructorLogin> InstructorLogins { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<Adminn> Admins { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstructorLogins>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<InstructorLogins>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<InstructorLogins>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<InstructorLogins>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<InstructorLogin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<InstructorLogin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.PostTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.PostDescription)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.Password)
                .IsUnicode(false);
            modelBuilder.Entity<Adminn>()
               .Property(e => e.Email)
               .IsUnicode(false);

            modelBuilder.Entity<Adminn>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
