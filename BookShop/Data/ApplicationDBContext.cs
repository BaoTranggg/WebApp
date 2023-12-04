using BookShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data
{
    public class ApplicationDBContext : IdentityDbContext //tat ca viec lam lien quan den database
    {
		public DbSet<Category> Categories { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<ApplicationUser> applicationUsers { get; set; }
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Horror", Description = "So scary", DisplayOrder = 2 },
                new Category { Id = 2, Name = "Action", Description = "So cool", DisplayOrder = 3 },
                new Category { Id = 3, Name = "Romance", Description = "So romance", DisplayOrder = 1 },
                new Category { Id = 4, Name = "Science", Description = "So difficult", DisplayOrder = 4 }
            );
			modelBuilder.Entity<Book>().HasData(
				new Book 
                { 
                    Id = 1, 
                    Title = "C# Programming", 
                    Description = "Hello", 
                    Author = "Anne",
                    Price = 10,
                    CategoryId = 1
                },
				new Book
				{
					Id = 2,
					Title = "Java Programming",
					Description = "Hello",
					Author = "Jane",
					Price = 15,
					CategoryId = 3
				},
				new Book
				{
					Id = 3,
					Title = "Python Programming",
					Description = "Hello",
					Author = "Billy",
					Price = 20,
					CategoryId = 2
				},
				new Book
				{
					Id = 4,
					Title = "C Programming",
					Description = "Hello",
					Author = "Jessica",
					Price = 15,
					CategoryId = 4
				}
			);
		}
    }
}
