using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace callList.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Post[] postsToSeed = new Post[6];

            for (int i = 0; i < postsToSeed.Length; i++)
            {
                postsToSeed[i] = new Post
                {
                    Id = i+1,
                    FirstName = $"Elena",
                    LastName = $"Siva",
                    Email = $"elena@siva.sk",
                    PhoneNumber = $"+421905342347"

                };
            }
            modelBuilder.Entity<Post>().HasData(postsToSeed);


        }
    }
}
