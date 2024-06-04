using API_CRUD_VALIDAÇÃO.Data;
using API_CRUD_VALIDAÇÃO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_VALIDAÇÃO.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }
        // Listar
        [HttpGet]
        public IActionResult getAll()
        {
            var users = _context.Users;//Busca dos dados no banco sem especificação, retorna tudo
            return Ok(users);//Retono do que foi buscado
        }

        // Inserir
        [HttpPost]
        public IActionResult Add([FromBody] User user)
        {
            // Verifica se o email já está cadastrado
            var emailExists = _context.Users.Any(x => x.Email == user.Email);
            if (emailExists)
            {
                return BadRequest("Email já cadastrado!");
            }

            // Verifica se a senha já está cadastrada
            var senhaExists = _context.Users.Any(x => x.Senha == user.Senha);
            if (senhaExists)
            {
                return BadRequest("Senha já cadastrada!");
            }

            // Se ambos não existirem, adiciona o usuário
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("Usuário cadastrado com sucesso!");
        }

        // Atualizar
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] User entity)
        {
            // Busca o usuário pelo ID
            var existingUser = _context.Users.FirstOrDefault(x => x.Id == id);
            if (existingUser == null)
            {
                return NotFound("Usuário não encontrado");
            }

            // Atualiza apenas os campos fornecidos na requisição e que não estão como "string"
            if (entity.Nome != null && entity.Nome != "string")
            {
                existingUser.Nome = entity.Nome;
            }
            if (entity.Sobrenome != null && entity.Sobrenome != "string")
            {
                existingUser.Sobrenome = entity.Sobrenome;
            }
            if (entity.Email != null && entity.Email != "string")
            {
                existingUser.Email = entity.Email;
            }
            if (entity.Senha != null && entity.Senha != "string")
            {
                existingUser.Senha = entity.Senha;
            }
            if (entity.Telefone != null && entity.Telefone != "string")
            {
                existingUser.Telefone = entity.Telefone;
            }

            // Marca o usuário como modificado e salva as alterações no banco de dados
            _context.Users.Update(existingUser);
            _context.SaveChanges();

            return Ok("Dados atualizados");
        }

        // Excluir
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound("Usuário não encontrado");
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok("Usuário excluído com sucesso!");
        }

        [HttpPost("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var empresa = await _context.Users.FirstOrDefaultAsync(x => x.Id == Id);

            if (empresa == null)
            {
                return BadRequest("");
            }

            return Ok(empresa);
        }


    }
}

