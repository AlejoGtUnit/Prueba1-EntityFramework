using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TutorialEntityFramework
{
    public class ColegioContext : DbContext
    {
        public ColegioContext() : base()
        {

        }

        public ColegioContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Database.SetInitializer<ColegioContext>(new DropCreateDatabaseIfModelChanges<ColegioContext>());
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Grado> Grados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using Fluent API here
            base.OnModelCreating(modelBuilder);
        }
    }
}
