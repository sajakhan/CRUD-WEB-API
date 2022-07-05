using BookManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Admin> Admin
        {
            get;
            set;
        }
        public DbSet<Book> Book
        {
            get;
            set;
        }
        public DbSet<Author> Author
        {
            get;
            set;
        }
        public DbSet<Warehouse> Warehouse
        {
            get;
            set;
        }
        public DbSet<Publisher> Publisher
        {
            get;
            set;
        }
        
    }
}
