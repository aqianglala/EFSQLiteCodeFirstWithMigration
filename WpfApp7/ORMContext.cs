using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public class ORMContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<ORMContext>(modelBuilder);
            //Database.SetInitializer(sqliteConnectionInitializer);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ORMContext, ContextMigrationConfiguration>(true));
        }
        public ORMContext() : base("ORMContext") { } //配置使用的连接名
        public DbSet<EmployInfo> EmployInfos { get; set; }
        public DbSet<DeptInfo> DeptInfos { get; set; }
    }

    internal sealed class ContextMigrationConfiguration : DbMigrationsConfiguration<ORMContext>
    {
        public ContextMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }
    }
}
