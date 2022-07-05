using BookManagementSystem.Models;
using BookManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BookManagementSystem.AuthenticationHandlers;

namespace BookManagementSystem.Controllers
{
    /*[Authorize]*/
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ExceptionFilters]
    public class WarehouseController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public WarehouseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [Authorize]
        [HttpGet]
        public IEnumerable<Warehouse> GetAllWarehouse()
        {
            var books = unitOfWork.Warehouse.GetAll();
            return books;
        }
        [HttpGet("{id}")]

        public Warehouse GetWarehouseById(int id)
        {
            return unitOfWork.Warehouse.GetById(id);

        }
        [HttpPost]
        public void Post([FromBody] Warehouse entity)
        {
            unitOfWork.Warehouse.Add(entity);
            unitOfWork.Save();
        }
        [Authorize]
        [HttpDelete("{id}")]
        public void RemoveWarehouse(int id)
        {
            unitOfWork.Warehouse.Remove(id);
            unitOfWork.Save();

        }
    }
}
