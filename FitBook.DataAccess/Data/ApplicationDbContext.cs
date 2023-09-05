using FitBook.Models;
using Microsoft.EntityFrameworkCore;

namespace FitBook.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



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
