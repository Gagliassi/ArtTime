using System;
using System.ComponentModel.DataAnnotations;

namespace ArtTime.Models
{
    public class Cliente
    {
        public Cliente() => CriadoEm = DateTime.Now;
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Contato { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}