using HrMatch.DB.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrMatch.DB
{
   public  class HrConnect : DbContext
    {
        public HrConnect()
            :base("Server= DESKTOP-SAVE5C2\\SQLEXPRESS; Database=HrSecond;Trusted_Connection=True;")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cv> Cvs { get; set; }
        public DbSet<Elan> Elans { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Work> Works { get; set; }






    }
}
