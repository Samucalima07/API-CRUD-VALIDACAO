using API_CRUD_VALIDAÇÃO.Data;
using API_CRUD_VALIDAÇÃO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_VALIDAÇÃO.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {

        private readonly DataContext _context;

        public UserLoginController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == userLogin.Email);
            if (user == null)
            {
                return BadRequest("Usuário não encontrado");
            }

            // Verifica se a senha fornecida corresponde à senha armazenada
            if (user.Senha != userLogin.Senha)
            {
                return BadRequest("Senha incorreta");
            }

            return Ok("Login bem-sucedido!");
        }
    }
}
