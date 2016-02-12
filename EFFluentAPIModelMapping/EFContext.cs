using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFFluentAPIModelMapping
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("EFDatabase")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseAlways<EFContext>());
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("Admin");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
