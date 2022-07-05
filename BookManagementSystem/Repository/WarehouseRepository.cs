using BookManagementSystem.Data;
using BookManagementSystem.Models;

namespace BookManagementSystem.Repository
{
    class WarehouseRepository : GenericRepository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(ApplicationDbContext context) : base(context) { }
    }
}