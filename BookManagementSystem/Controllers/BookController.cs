using BookManagementSystem.Models;
using BookManagementSystem.Repository;
using BookManagementSystem.AuthenticationHandlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace BookManagementSystem.Controllers
{
    /*[Authorize]*/
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionFilters]
    
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public BookController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [Authorize]
        [HttpGet]
        [Route("GetBooks")]
        public IEnumerable<Book> GetAllBooks()
        {
            var books = unitOfWork.Book.GetAll();
            return books;
        }
      /*  [HttpGet]
        [Route("GetBookInfo")]
        public IEnumerable<Book> GetAllBooksInfo()
        {
            var books = unitOfWork.Book.GetBooksDescription();
            return books;
        }*/
              [Authorize]

        [HttpGet("{id}")]
       
        public Book GetBookById(int id)
        {
            return unitOfWork.Book.GetById(id);

        }
        [HttpPost]
        public void Post([FromBody] Book entity)
        {
            unitOfWork.Book.Add(entity);
            unitOfWork.Save();
        }
        [Authorize]
        [HttpDelete("{id}")]
        public void RemoveBook(int id)
        {
            unitOfWork.Book.Remove(id);
            unitOfWork.Save();

        }
    }
}
