using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtTime.ClienteController
{
    [Route("api/cliente")]
    [ApiController]

    public class ClienteController
    {

        private static List<Cliente>();

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            return Ok();
        }

        //gera requisição via GET: /api/artista/buscar/{CPF}
        [HttpGet]
        [Route("buscar/{CPF}")]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            NomeDaTabela.FirstOrDefault(
                clienteCadastrado => clienteCadastrado.Cpf.Equals(cpf)
            );
            return cliente != null ? Ok(cliente) : NotFound();
        }


        //POST:  /api/cliente/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Cliente cliente)
        {
            _context.NomeDaTabela.Add(cliente);
            _context.SaveChanges();
            return Created("", clientes);
        }


        // DELETE: /api/cliente/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]

        public IActionResult Deletar([FromRoute] int id)
        {
            Cliente cliente = _context.NomeDaTabela.Find(id);
            if (cliente != null)
            {
                _context.NomeDaTabela.Remove(cliente);
                _context.SaveChanges();
                return Ok(cliente);
            }
            return NotFound();
        }

        // PATCH: /api/cliente/alterar
        [Route("alterar")]
        [HttpPatch]

        public IActionResult Alterar([FromBody] Cliente cliente)
        {

            _context.NomeDaTabela.Update(cliente);
            _context.SaveChanges();
            return Ok(cliente);
        }
    }
}