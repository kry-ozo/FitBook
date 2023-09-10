using FitBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitBook.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = 1,
                    Name = "Protein Soup",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Tempus quam pellentesque nec nam aliquam sem. ",
                    Steps = "Donec ultrices tincidunt arcu non sodales neque sodales.",
                    Protein = 20,
                    Fats = 10,
                    Carbs = 65
                },
                new Recipe
                {
                    Id = 2,
                    Name = "Protein Soup",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Tempus quam pellentesque nec nam aliquam sem. ",
                    Steps = "Donec ultrices tincidunt arcu non sodales neque sodales.",
                    Protein = 20,
                    Fats = 10,
                    Carbs = 65
                },
                new Recipe
                {
                    Id = 3,
                    Name = "Protein Soup",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Tempus quam pellentesque nec nam aliquam sem. ",
                    Steps = "Donec ultrices tincidunt arcu non sodales neque sodales.",
                    Protein = 20,
                    Fats = 10,
                    Carbs = 65
                }

                );



        }
    }
}
