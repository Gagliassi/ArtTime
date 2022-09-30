using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;


namespace ArtTime.ArtistaController
{
    [Route("api/artista")]
    [ApiController]
    public class ArtistaController : ControllerBase
    {
        private readonly DataContext _context;

        public ArtistaController(DataContext context) =>
            _context = context;


        private static List<Artista> artistas = new List<Artista>();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() =>
            Ok(_context.Artistas.ToList());


        //POST:  /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Artista artista)
        {
            _context.Artistas.Add(artista);
            _context.SaveChanges();
            return Created("", artistas);
        }


        // DELETE: /api/artista/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]

        public IActionResult Deletar([FromRoute] int id)
        {
            Artista artista = _context.Artistas.Find(id);
            if (artista != null)
            {
                _context.Artistas.Remove(artista);
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

            _context.Artistas.Update(artista);
            _context.SaveChanges();
            return Ok(artista);
        }
    }
}