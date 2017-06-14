using ProjetoCidade.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoCidade.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext") 
        {

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());

        }


        public DbSet<Pais> pais { get; set; }

        public DbSet<Estado> estado { get; set; }

        public DbSet<Cidade> cidade { get; set; }


    }
}