using BookManagementSystem.Data;
using BookManagementSystem.Models;

namespace BookManagementSystem.Repository
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(ApplicationDbContext context) : base(context) { }

    }
}
