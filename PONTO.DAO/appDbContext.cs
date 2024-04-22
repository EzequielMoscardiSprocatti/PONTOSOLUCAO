using Microsoft.EntityFrameworkCore;
using PONTO.DOMAIN.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DAO
{
    public class appDbContext : DbContext
    {

        public DbSet<Beneficios> Beneficios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Contratacao> Contratacaos { get; set; }

        public DbSet<Email> Emails { get; set; }

        public DbSet<Emprestimo> Emprestimos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Historico> Historicos { get; set; }

        public DbSet<ResultadoBot> resultadoBots { get; set; }

        public DbSet<Telefone> Telefones { get; set; }

        public DbSet<DisparosAcaoMkt> disparosAcaos { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var connString = "Server=82.180.153.154;Database=u165745573_pontopromotora;Uid=u165745573_pontopromotora;Pwd=8!Ezeq1234;";
                options.UseMySql(connString, ServerVersion.AutoDetect(connString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
        }


    }
}
