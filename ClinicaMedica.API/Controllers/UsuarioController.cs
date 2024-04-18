using ClinicaMedica.Application.Commands.Usuarios.CreateUser;
using ClinicaMedica.Application.Commands.Usuarios.DeleteUser;
using ClinicaMedica.Application.Commands.Usuarios.LoginUser;
using ClinicaMedica.Application.Commands.Usuarios.UpdateUser;
using ClinicaMedica.Application.Queries.Usuarios.GetAllUser;
using ClinicaMedica.Application.Queries.Usuarios.GetUserByEmail;
using ClinicaMedica.Application.Queries.Usuarios.GetUserById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaMedica.API.Controllers
{
    [Route("api/usuarios")]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllUsersQuery();

            if (query == null)
                return BadRequest();

            var usuarios = await _mediator.Send(query);

            return Ok(usuarios);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var queryId = new GetUserByIdQuery(id);

            if (queryId == null)
                return NotFound();

            var usuario = await _mediator.Send(queryId);

            return Ok(usuario);
        }
        [HttpGet("email")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var emailQuery = new GetUserByEmailQuery(email);

            if (emailQuery == null)
                return NotFound();

            var usuario = await _mediator.Send(emailQuery);

            return Ok(usuario);
        }
        [HttpPost("CriarUsuario")]
        [AllowAnonymous]
        public async Task<IActionResult> PostUser([FromBody] CreateUserCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new {id = id}, command);
        }
        [HttpPut("CriarLogin")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
        {
            var loginViewModel = await _mediator.Send(command);

            if(loginViewModel == null)
                return Unauthorized();

            return Ok(loginViewModel);
        }
        [HttpPut("{id}/AtualizarUsuario")]
        public async Task<IActionResult> PutUser([FromBody] UpdateUserCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
        [HttpDelete("{id}/DeletarUsuario")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var command = new DeleteUserCommand(id);

            if(command ==null) 
                return NotFound();

            await _mediator.Send(command);  

            return NoContent();
        }
    }
}
