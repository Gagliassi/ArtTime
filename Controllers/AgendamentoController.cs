using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtTime.AgendamentoController
{
    [Route("api/agendamento")]
    [ApiController]

    public class AgendamentoController
    {

        private static List<Agendamento>();

         //POST:  /api/agendamento/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Agendamento agendamento)
        {
            _context.NomeDaTabela.Add(agendamento);
            _context.SaveChanges();
            return Created("", agendamentos);
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            return Ok();
        }

        //gera requisição via GET: /api/artista/buscar/{CPF}
        [HttpGet]
        [Route("buscar/{Nome}")]
        public IActionResult Buscar([FromRoute] string nomeArtista)
        {
            NomeDaTabela.FirstOrDefault(
                artistaCadastrado => artistaCadastrado.Cpf.Equals(nomeArtista)
            );
            return nomeArtista != null ? Ok(nomeArtista) : NotFound();
        }

    }
}