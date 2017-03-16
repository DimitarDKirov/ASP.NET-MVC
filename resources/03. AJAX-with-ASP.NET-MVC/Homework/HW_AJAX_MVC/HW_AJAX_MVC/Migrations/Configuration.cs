namespace HW_AJAX_MVC.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HW_AJAX_MVC.Data.MoviesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HW_AJAX_MVC.Data.MoviesDbContext context)
        {
            if (context.Movies.Count() > 0)
            {
                return;
            }

            var godfather = new MovieDbModel
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Year = 1972,
                LeadingMaleRole = "Marlon Brando",
                LeadingMaleRoleAge = 48,
                LeadingFemaleRole = "Diane Keaton",
                LeadingFemaleRoleAge = 26,
                Studio = "Paramount Pictures",
                StudioAddress = "Holywood"
            };

            context.Movies.Add(godfather);

            var taxi = new MovieDbModel
            {
                Title = "Taxi",
                Director = "Gerard Pires",
                Year = 1998,
                LeadingMaleRole = "Samy Naceri",
                LeadingMaleRoleAge = 37,
                LeadingFemaleRole = "Marion Cotillard",
                LeadingFemaleRoleAge = 23,
                Studio = "Canal+",
                StudioAddress = "Marselie, France"
            };

            context.Movies.Add(taxi);
            context.SaveChanges();
        }
    }
}
