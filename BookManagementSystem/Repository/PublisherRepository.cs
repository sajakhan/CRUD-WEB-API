using BookManagementSystem.Data;
using BookManagementSystem.Models;

namespace BookManagementSystem.Repository
{
    class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(ApplicationDbContext context) : base(context) { }
    }
}