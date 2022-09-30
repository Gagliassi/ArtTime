using System;
using System.ComponentModel.DataAnnotations;

namespace ArtTime.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Procedimento { get; set; }
        public string Localizacao { get; set; }
    }
}