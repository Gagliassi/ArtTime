using System;
using System.ComponentModel.DataAnnotations;

namespace ArtTime.Models
{
    public class Artista
    {
        //Data Annotations
        public Artista() => CriadoEm = DateTime.Now;
        public int ArtistaId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}