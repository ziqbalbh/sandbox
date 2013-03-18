using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace consoleBox
{
    class BoxContext : DbContext
    {
        public DbSet<PersonItem> PersonItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonItemConfiguration());
            modelBuilder.Configurations.Add(new EmailItemConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
