using BookShopping.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShopping.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Book_Users> Reg_Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Users>().HasData(
                    new Book_Users { Id=1, Name="Sadasivam", email="sadasivam@gmail.com", password="sada", re_password="sada"},
                    new Book_Users { Id = 2, Name = "Abcd", email = "abcd@gmail.com", password = "abcd", re_password = "abcd" }
                );
        }

    }
}
