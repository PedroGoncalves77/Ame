using Ame.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ame.BD
{
    internal class BD_Context : DbContext
    {
        public DbSet<FichaBebeTresMeses> FichaBebeTresMeses { get; set; }  
        public DbSet<SaudeDaCrianca> SaudeDaCriancas { get; set; }
        public DbSet<AlimentacaoCrianca> AlimentacaoCrianca { get; set; }   
         
        public DbSet<NivelDeAtividade> NivelDeAtividade { get; set; }   

        private string ConexaoBD = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BD_AME3;Integrated Security=True;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConexaoBD).UseLazyLoadingProxies();
        }
    }
}
