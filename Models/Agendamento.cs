using System;
using System.ComponentModel.DataAnnotations;

namespace ArtTime.Models
{
    public class Agendamento
    {
        //Data Annotations
        public Agendamento() => CriadoEm = DateTime.Now;
        public int AgendamentoId { get; set; }
        public string Cliente { get; set; }
        public string Artista { get; set; }
        public string Produto { get; set; }
        public string DataAgendamento { get; set; }
        public string Horario { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}