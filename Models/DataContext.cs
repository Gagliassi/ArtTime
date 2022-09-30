using Microsoft.EntityFrameworkCore;

namespace ArtTime.Models
{
    //Classe que reprenta o banco de dados dentro da aplicação
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
            base(options)
        { }

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}