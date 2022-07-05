using BookManagementSystem.Models;
using BookManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BookManagementSystem.AuthenticationHandlers;

namespace BookManagementSystem.Controllers
{
   /* [Authorize]*/

    [Route("api/[controller]")]
    [ApiController]
    [ExceptionFilters]
   
    public class PublisherController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PublisherController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [Authorize]
        [HttpGet]
        public IEnumerable<Publisher> GetAllPublisher()
        {
            var address = unitOfWork.Publisher.GetAll();
            return address;
        }
        [Authorize]

        [HttpGet("{id}")]

        public Publisher GetPublisherById(int id)
        {
            return unitOfWork.Publisher.GetById(id);

        }
        [HttpPost]
        public void Post([FromBody] Publisher entity)
        {
            unitOfWork.Publisher.Add(entity);
            unitOfWork.Save();
        }
        [HttpDelete("{id}")]
        public void RemovePublisher(int id)
        {
            unitOfWork.Publisher.Remove(id);
            unitOfWork.Save();

        }
    }
}
