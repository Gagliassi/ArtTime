using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtTime.ArtistaController
{
    [Route("api/artista")]
    [ApiController]

    public class ArtistaController
    {

        private static List<Artista>();

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
                artistaCadastrado => artistaCadastrado.Cpf.Equals(cpf)
            );
            return artista != null ? Ok(artista) : NotFound();
        }


        //POST:  /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Artista artista)
        {
            _context.NomeDaTabela.Add(artista);
            _context.SaveChanges();
            return Created("", artistas);
        }


        // DELETE: /api/artista/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]

        public IActionResult Deletar([FromRoute] int id)
        {
            Artista artista = _context.NomeDaTabela.Find(id);
            if (artista != null)
            {
                _context.NomeDaTabela.Remove(artista);
                _context.SaveChanges();
                return Ok(artista);
            }
            return NotFound();
        }

        // PATCH: /api/artista/alterar
        [Route("alterar")]
        [HttpPatch]

        public IActionResult Alterar([FromBody] Artista artista)
        {

            _context.NomeDaTabela.Update(artista);
            _context.SaveChanges();
            return Ok(artista);
        }
    }
}