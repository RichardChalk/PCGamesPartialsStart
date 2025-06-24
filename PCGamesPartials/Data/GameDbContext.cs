using Microsoft.EntityFrameworkCore;
using PCGamesPartials.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PCGamesPartials.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) 
            : base(options) { }

        public DbSet<PCGame> PCGames { get; set; }

        // Med denna slipper vi 'DataInitializer' klass!
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PCGame>().HasData(
                new PCGame { Id = 1, Title = "Cyberpunk 2077", Genre = "RPG", Description = "Futuristisk open-world shooter.", ImageUrl = "/images/cyberpunk.jpg", Price = 599 },
                new PCGame { Id = 2, Title = "Elden Ring", Genre = "Action RPG", Description = "Fantasyvärld med tuffa bossar.", ImageUrl = "/images/eldenring.jpg", Price = 699 },
                new PCGame { Id = 3, Title = "Valorant", Genre = "FPS", Description = "Taktisk 5v5 shooter.", ImageUrl = "/images/valorant.jpg", Price = 0 },
                new PCGame { Id = 4, Title = "The Witcher 3", Genre = "RPG", Description = "Episkt äventyr med Geralt.", ImageUrl = "/images/witcher3.jpg", Price = 299 },
                new PCGame { Id = 5, Title = "CS2", Genre = "FPS", Description = "Klassisk tävlingsskjutare.", ImageUrl = "/images/cs2.jpg", Price = 0 },
                new PCGame { Id = 6, Title = "Minecraft", Genre = "Sandbox", Description = "Bygg, utforska, överlev.", ImageUrl = "/images/minecraft.jpg", Price = 269 }
            );
        }
    }
}
