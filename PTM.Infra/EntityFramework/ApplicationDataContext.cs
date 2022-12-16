using Microsoft.EntityFrameworkCore;
using PTM.Domain.Models.Users;
using PTM.Domain.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using PTM.Infra.EntityFramework.Configurations;
using PTM.Infra.EntityFramework.Configurations.Tasks;

namespace PTM.Infra.EntityFramework
{
    public class ApplicationDataContext : DbContext
    {
        public DbSet<Work> Tasks { get; set; }
        //DbSet<UserEntity> Users { get; set; }
        private DbConfiguration Db = new DbConfiguration("PTM.db");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {Db.ConnectionString}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TaskConfiguration());
        }
    }
}
