using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EatAndDrink.Models;

namespace EatAndDrink.Data
{
    public class EatAndDrinkContext : DbContext
    {
        private readonly String _connectionString = "Data Source=KOMPUTER; Initial Catalog=EatAndDrinkDB; Persist Security Info=True;TrustServerCertificate=True;User ID = sa; Password=1007";
        public EatAndDrinkContext (DbContextOptions<EatAndDrinkContext> options)
            : base(options)
        {
        }

        public DbSet<EatAndDrink.Models.Client> Client { get; set; } = default!;
        public DbSet<EatAndDrink.Models.Courier> Couriers { get; set; } = default!;
        public DbSet<EatAndDrink.Models.Dish>Dishes { get; set; } = default!;
        public DbSet<EatAndDrink.Models.Menu> Menus { get; set; } = default!;
        public DbSet<EatAndDrink.Models.Order> Orders { get; set; } = default!;
        public DbSet<EatAndDrink.Models.Restaurant> Restaurants { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
       options.UseSqlServer(_connectionString);
    }
}
