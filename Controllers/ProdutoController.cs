using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;


namespace ArtTime.ProdutoController
{
    [Route("api/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;

        public ProdutoController (DataContext context) =>
            _context = context;


        private static List<Produto> produtos = new List<Produto>();

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar() =>
            Ok(_context.Produtos.ToList());


        //POST:  /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Created("", produto);
        }

        // DELETE: /api/artista/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]

        public IActionResult Deletar([FromRoute] int id)
        {
            Produto produto = _context.Produtos.Find(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
                return Ok(produto);
            }
            return NotFound();
        }

        // PATCH: /api/artista/alterar
        [Route("alterar")]
        [HttpPatch]

        public IActionResult Alterar([FromBody] Produto produto)
        {

            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return Ok(produto);
        }
    }
}