using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BookManagementSystem.Models;
using BookManagementSystem.Data;
using BookManagementSystem.AuthenticationHandlers;

namespace BookManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionFilters]
    public class LoginController : ControllerBase
    {
        protected readonly ApplicationDbContext context;
        public LoginController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public IActionResult Login([FromBody] Admin loginDTO)
        {
            
            try
            {
                string name = context.Admin.FirstOrDefault(obj => obj.UserName == loginDTO.UserName)?.UserName;
                string pass = context.Admin.FirstOrDefault(obj => obj.Password == loginDTO.Password)?.Password;
                if (string.IsNullOrEmpty(loginDTO.UserName) ||
                string.IsNullOrEmpty(loginDTO.Password))
                    return BadRequest("Username and/or Password not specified");
                if (loginDTO.UserName.Equals(name) &&
                loginDTO.Password.Equals(pass))
                {
                    var secretKey = new SymmetricSecurityKey
                    (Encoding.UTF8.GetBytes("thisisasecretkey@123"));
                    var signinCredentials = new SigningCredentials
                   (secretKey, SecurityAlgorithms.HmacSha256);
                    var jwtSecurityToken = new JwtSecurityToken(
                        issuer: "ABCXYZ",
                        audience: "http://localhost:7015",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(10),
                        signingCredentials: signinCredentials
                    );
                    return Ok(new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken));
                }
            }
            catch
            {
                return BadRequest
                ("An error occurred in generating the token");
            }
            return Unauthorized();
        }
    }
}
