using Microsoft.EntityFrameworkCore;

namespace IMDB.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IMDBContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<IMDBContext>>()))
                {
                    if (context == null || context.Movie == null)
                    {
                        throw new ArgumentNullException("Null IMDBContext");
                    }

                    // Look for any movies.
                    if (context.Movie.Any())
                    {
                        return; //DB has been seeded.
                    }

                    context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R",
                        Director = "Johnson"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG",
                        Director = "Phillman"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG",
                        Director = "Jeffrey"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R",
                        Director = "Anderson"
                    }
                );
                context.SaveChanges();

                }
        }
    }
}