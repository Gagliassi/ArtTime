using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;


namespace ArtTime.AgendamentoController
{
    [Route("api/agendameto")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private readonly DataContext _context;

        public AgendamentoController (DataContext context) =>
            _context = context;


        private static List<Agendamento> agendamentos = new List<Agendamento>();

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar() =>
            Ok(_context.Agendamentos.ToList());


        //POST:  /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Agendamento agendamento)
        {
            _context.Agendamentos.Add(agendamento);
            _context.SaveChanges();
            return Created("", agendamento);
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
            Agendamento agendamento = _context.Agendamentos.Find(id);
            if (agendamento != null)
            {
                _context.Agendamentos.Remove(agendamento);
                _context.SaveChanges();
                return Ok(agendamento);
            }
            return NotFound();
        }

        // PATCH: /api/artista/alterar
        [Route("alterar")]
        [HttpPatch]

        public IActionResult Alterar([FromBody] Agendamento agendamento)
        {

            _context.Agendamentos.Update(agendamento);
            _context.SaveChanges();
            return Ok(agendamento);
        }
    }
}