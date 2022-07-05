using BookManagementSystem.Data;
using BookManagementSystem.Models;

namespace BookManagementSystem.Repository
{
    class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context) { }
    }
}