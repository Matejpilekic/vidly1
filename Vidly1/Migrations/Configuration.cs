namespace Vidly1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vidly1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vidly1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Vidly1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            if (!context.Customers.Any())
            {
                context.Customers.AddOrUpdate(
                    new Customer { Name = "Matej Pilekic", BirthDate = DateTime.Now, IsSubscribedToNewsletter = true, MembershipTypeId = 1 },
                    new Customer { Name = "Marija Wiliams", BirthDate = DateTime.Now, IsSubscribedToNewsletter = false, MembershipTypeId = 2 },
                    new Customer { Name = "Ranko Ranic", BirthDate = DateTime.Now, IsSubscribedToNewsletter = false, MembershipTypeId = 2 }
              );
                
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddOrUpdate(
                    new Movie { Name = "Superman", ReleaseDate = DateTime.Now, DateAdded = DateTime.Now, NumberInStock = 12, GenreId = 3 },
                    new Movie { Name = "Batman", ReleaseDate = DateTime.Now, DateAdded = DateTime.Now, NumberInStock = 12, GenreId = 3 },
                    new Movie { Name = "Shrek", ReleaseDate = DateTime.Now, DateAdded = DateTime.Now, NumberInStock = 12, GenreId = 1 }
                    );
            }

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
