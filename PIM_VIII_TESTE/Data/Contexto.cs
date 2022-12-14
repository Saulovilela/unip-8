using Microsoft.EntityFrameworkCore;
using PIM_VIII_TESTE.Data.Map;
using PIM_VIII_TESTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_VIII_TESTE.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Pessoas> Pessoas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());

            base.OnModelCreating(modelBuilder);
        }

    

        

       
    }
}
