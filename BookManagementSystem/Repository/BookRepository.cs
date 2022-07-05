using BookManagementSystem.Data;
using BookManagementSystem.Models;
using System.Linq;
namespace BookManagementSystem.Repository
{
    class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context) { }

        /*public IEnumerable<Book> GetBooksDescription()
        {
            var a = context.Author.FirstOrDefault();
           *//* foreach(Book b in a.Books)
            {
                Console.WriteLine(b.Title + "\t" + a.AuthorName);

            }*//*
            return a.Books;

        }*/
    }
}