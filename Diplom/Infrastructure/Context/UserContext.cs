using JWT.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace JWT.Infrastructure.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Share> Shares { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<ShareStack> ShareStacks { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //string adminEmail = "admin@mail.ru";
            //string adminPasswordHash = "123456";
            //string adminName = "Admin";

            //User adminUser = new User { Id = 1, Email = adminEmail, PasswordHash = adminPassword, Name = adminName };
            //modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            //base.OnModelCreating(modelBuilder);
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().Where(e => !e.IsOwned()).SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}
        }
      




    }
}