using Microsoft.AspNetCore.Mvc;
using ArtTime.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArtTime.PdrodutoController
{
    [Route("api/produto")]
    [ApiController]

    public class ProdutoController
    {

        private static List<Produto>();

    [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            return Ok();
        }

        //gera requisição via GET: /api/produto/buscar/{produto}
        [HttpGet]
        [Route("buscar/{CPF}")]
        public IActionResult Buscar([FromRoute] string produto)
        {
            NomeDaTabela.FirstOrDefault(
                produtoCadastrado => proudutoCadastrado.Cpf.Equals(cpf)
            );
            return produto != null ? Ok(produto) : NotFound();
        }


        //POST:  /api/produto/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Produto produto)
        {
            _context.NomeDaTabela.Add(produto);
            _context.SaveChanges();
            return Created("", produtos);
        }


        // DELETE: /api/artista/deletar/1
        [Route("deletar/{id}")]
        [HttpDelete]

        public IActionResult Deletar([FromRoute] int id)
        {
            Produto produto = _context.NomeDaTabela.Find(id);
            if (produto != null)
            {
                _context.NomeDaTabela.Remove(produto);
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

            _context.NomeDaTabela.Update(produto);
            _context.SaveChanges();
            return Ok(produto);
        }
    }
}