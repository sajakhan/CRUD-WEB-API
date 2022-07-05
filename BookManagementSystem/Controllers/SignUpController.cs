using BookManagementSystem.Models;
using BookManagementSystem.Repository;
using BookManagementSystem.AuthenticationHandlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BookManagementSystem.Data;

namespace BookManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class SignUpController
    {
        
        private readonly IUnitOfWork unitOfWork;
        public SignUpController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            
        }
        [HttpPost]
        public void Signup([FromBody] Admin entity)
        {
            unitOfWork.Admin.Add(entity);
            unitOfWork.Save();
        }
     }
}
