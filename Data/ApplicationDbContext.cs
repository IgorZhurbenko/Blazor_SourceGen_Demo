using Data.Entities;
using Data.Entities.Documents;
using Data.Entities.Documents.Trade;
using Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
namespace Data
{
    public partial class ApplicationDbContext : DbContext
    {
        static readonly bool Postgres = false;
        public uint SuperUserID;
        public void EnsureSuperUserPresence()
        {
            string superUserName = "TechAdmin";
            var superUser = Users.AsNoTracking().Include(u => u.Permissions).FirstOrDefault(u => u.LoginName == superUserName);

            bool createNew = false;

            if (superUser == null)
            {
                superUser = new Entities.DataHolders.AccountingUsers.User();
                superUser.PasswordHash = "".Hash();
                createNew = true;
            }
            superUser.LoginName = superUserName;
            var superPermissions = new Permissions();
            foreach (var p in superPermissions.ToDictionary())
            {
                p.Value.Setter(true);
            }
            superPermissions.TechnicalAdministrating = true;

            superUser.Permissions = superPermissions;

            superUser.Representation = superUserName;

            Users.Update(superUser);

            SuperUserID = superUser.ID;

            SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            base.OnConfiguring(dbContextOptionsBuilder);
            string path = $@"{AppDomain.CurrentDomain.BaseDirectory}\db.db";

            if (Postgres)
            {
                dbContextOptionsBuilder.UseNpgsql("Host=localhost;Port=5500;Database=blazoronrail;Username=postgres;Password=124816");
            }
            else
            {
                dbContextOptionsBuilder.UseSqlite(@$"Data Source={path}", b => b.MigrationsAssembly("Data"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AutoExpandDataScheme();
        }

        public ApplicationDbContext()
        {
            this.Database.EnsureCreated();
        }
    }
}