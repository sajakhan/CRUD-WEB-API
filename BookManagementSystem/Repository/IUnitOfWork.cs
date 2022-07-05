using BookManagementSystem.Models;

namespace BookManagementSystem.Repository
{
    public interface IUnitOfWork
    {
        IBookRepository Book
        {
            get;
        }
        IAuthorRepository Author
        {
            get;
        }
        IPublisherRepository Publisher
        {
            get;
        }
        IWarehouseRepository Warehouse
        {
            get;
        }
        IAdminRepository Admin
        {
            get;
        }

        void Save();
    }
}
