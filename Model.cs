using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Model
{
    public class GameContext : DbContext
    {
        //this is actual entity object linked to the games in our DB
        public DbSet<Game> Games { get; set; }

        //this method is run automatically by EF the first time we run the application
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //here we define the name of our database
            optionsBuilder.UseNpgsql("User ID=postgres;Password=admin;Host=localhost;Port=5432;Database=GameDB;Pooling=true;");
        }
    }

    //this is the typed representation of a movie in our project
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Platform { get; set; }
        public string Genre { get; set; }
        public string Pegi { get; set; }
    }
}