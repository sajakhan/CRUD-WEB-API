using BookManagementSystem.Models;
using BookManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BookManagementSystem.AuthenticationHandlers;

namespace BookManagementSystem.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   

    public class AuthorController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public AuthorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [Authorize]
        [HttpGet]
        public IEnumerable<Author> GetAllAuthors()
        {
            var address = unitOfWork.Author.GetAll();
            return address;
        }
        [Authorize]

        [HttpGet("{id}")]

        public Author GetAuthorById(int id)
        {
            return unitOfWork.Author.GetById(id);

        }
        
        [HttpPost]
        public void Post([FromBody] Author entity)
        {
            unitOfWork.Author.Add(entity);
            unitOfWork.Save();
        }
        [Authorize]
        [HttpDelete("{id}")]
        public void RemoveAddress(int id)
        {
            unitOfWork.Author.Remove(id);
            unitOfWork.Save();

        }


    }


}
