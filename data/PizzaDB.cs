using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


namespace la_mia_pizzeria_static.data
{
    public class PizzaDB : IdentityDbContext<IdentityUser>
    {
        public DbSet<Pizza>Pizze { get; set; }
        public DbSet<Category>Categoryes { get; set; }
        public DbSet<Message> messages { get; set; }

        public DbSet<Ingredient> Ingredientes { get; set; }

        public PizzaDB(DbContextOptions<PizzaDB> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}
