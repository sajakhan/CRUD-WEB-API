
using BookManagementSystem.Data;
using BookManagementSystem.Repository;

namespace BookManagementSystem.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext context;
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            Book = new BookRepository(this.context);
            Author = new AuthorRepository(this.context);
            Publisher = new PublisherRepository(this.context);
            Warehouse = new WarehouseRepository(this.context);
            Admin = new AdminRepository(this.context);  
        }
        public IBookRepository Book
        { get; private set; }

        public IAuthorRepository Author { get; private set; }

        public IPublisherRepository Publisher { get; private set; }
        public IWarehouseRepository Warehouse { get; private set; }
        public IAdminRepository Admin { get; private set; }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
