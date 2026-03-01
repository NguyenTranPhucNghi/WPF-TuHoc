using Microsoft.EntityFrameworkCore;
using WBF_Tuan_1.Models;

namespace WBF_Tuan_1.Data
{
    class AppDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlite("Data Source=WBFAppLearnDB.db");
        }
    }
}
