using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using PiecesOfArt.Models;

namespace PiecesOfArt
{
    public class ApppDbContext:DbContext
    {
        /*01115006605*/
        public ApppDbContext(DbContextOptions options):base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<User>()
            .HasOne(u => u.LoyaltyCard)
            .WithMany(c => c.Users);

            modelBuilder.Entity<PieceOfArt>()
                .HasOne(a => a.Category)
                .WithMany(c => c.PiecesOfArt);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Impressionism", Description = "A 19th-century art movement characterized by small, thin brush strokes and emphasis on light and movement." },
                 new Category { Id = 2, Name = "Renaissance", Description = "A period in European history marking the revival of classical learning and wisdom." },
                new Category { Id = 3, Name = "Abstract", Description = "Art that uses shapes, colors, forms, and gestural marks to achieve its effect rather than depicting objects." },
               new Category { Id = 4, Name = "Modern", Description = "A broad category that reflects artistic work produced during the late 19th to mid-20th century." },
                new Category { Id = 5, Name = "Ancient", Description = "Art from ancient civilizations, including Egyptian, Mesopotamian, and classical Greek." }
            );

            modelBuilder.Entity<LoyaltyCard>().HasData(
                new LoyaltyCard { Id = 1, Name = "Bronze", Description = "10% Off" },
               new LoyaltyCard { Id = 2, Name = "Silver", Description  = "20% Off" },
               new LoyaltyCard { Id = 3, Name = "Gold", Description    = "30% Off" },
                new LoyaltyCard { Id = 4, Name = "Platinum", Description = "40% Off" },
                new LoyaltyCard { Id = 5, Name = "Crystal", Description = "50% Off" }
            );

            modelBuilder.Entity<PieceOfArt>().HasData(
                   new PieceOfArt { Id = 1, Title = "Starry Night", Price = 100000, PublicationDate = DateTime.Now, CategoryId = 1 },
                new PieceOfArt { Id = 2,Title = "The Mona Lisa", Price = 500000, PublicationDate = DateTime.Now, CategoryId = 2 },
               new PieceOfArt { Id = 3, Title = "Composition VIII", Price = 120000, PublicationDate = DateTime.Now, CategoryId = 3 },
                new PieceOfArt { Id = 4, Title = "The Persistence of Memory", Price = 200000, PublicationDate = DateTime.Now, CategoryId = 4 },
                new PieceOfArt { Id = 5, Title = "Small Pyramid", Price = 150000, PublicationDate = DateTime.Now, CategoryId = 5 }
            );
                
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Momen1", Email = "Momen1@gmail.com", Age = 30, LoyaltyCardId = 1 },
                new User { Id = 2, Name = "Momen2", Email = "Momen2@gmail.com", Age = 25, LoyaltyCardId = 2 },
                new User { Id = 3, Name = "Momen3", Email = "Momen3@gmail.com", Age = 28, LoyaltyCardId = 3 },
                new User { Id = 4, Name = "Momen4", Email = "Momen4@gmail.com", Age = 22, LoyaltyCardId = 4 },
                new User { Id = 5, Name = "Momen5", Email = "Momen5@gmail.com", Age = 26, LoyaltyCardId = 5 }
            );

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PieceOfArt> PiecesOfArt { get; set; }
    }
}
