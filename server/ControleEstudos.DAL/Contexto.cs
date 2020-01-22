using System;
using ControleEstudos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEstudos.DAL
{
    public class Contexto : DbContext
    {
        DbSet<Estudo> Estudos {get;set;}

        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
           this.Database.EnsureCreated(); 
        }
    }
}