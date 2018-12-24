using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using Mapping;

namespace Repository.EF
{
    public class MusicStoreContext : DbContextBase
    {
        public MusicStoreContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer<MusicStoreContext>(null);
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<QYHDbContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MusicMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
