using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;


namespace ArtTime.ClienteController
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController (DataContext context) =>
            _context = context;


        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar() =>
            Ok(_context.Clientes.ToList());


        //POST:  /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Created("", cliente);
        }

        [Route("buscar/{cpf}")]
        [HttpGet]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            //Expressão lambda
            Agendamento agendamento =
                _context.Agendamentos.FirstOrDefault
            (
                f => f.AgendamentoId.Equals(cpf)
            );
            //IF ternário
            return agendamento != null ? Ok(agendamento) : NotFound();
        }


        // DELETE: /api/artista/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]

        public IActionResult Deletar([FromRoute] int id)
        {
            Cliente cliente = _context.Clientes.Find(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
                return Ok(cliente);
            }
            return NotFound();
        }

        // PATCH: /api/artista/alterar
        [Route("alterar")]
        [HttpPatch]

        public IActionResult Alterar([FromBody] Cliente cliente)
        {

            _context.Clientes.Update(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}