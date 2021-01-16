using MyGyM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGyM
{
    public class MyContext : DbContext
    {
        public MyContext() : base("KonekcijaNaBazu")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Members> Members { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<InterchangeableData> interchangeableDatas { get; set; }
    }
}
