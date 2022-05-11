using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AspNetAB.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AuthDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AuthDbContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        Image = "When Harry Met Sally.jpg",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R",
                        Director = "Rob Reiner",
                        Starring = "Billy Crystal, Meg Ryan, Carrie Fisher, Bruno Kirby",
                        Description = "Harry and Sally have known each other for years, and are very good friends, but they fear intimate contact would ruin the friendship."
                    },

                    new Movie
                    {
                        Title = "Ghostbusters",
                        Image = "Ghostbusters.jpg",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Horror",
                        Price = 8.99M,
                        Rating = "G",
                        Director = "Ivan Reitman",
                        Starring = "Bill Murray, Dan Aykroyd, Sigourney Weaver, Harold Ramis, Rick Moranis, Ernie Hudson",
                        Description = "Three parapsychologists forced out of their university funding set up shop as a unique ghost removal service in New York City, attracting frightened yet skeptical customers."
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        Image = "Ghostbusters 2.jpg",
                        ReleaseDate = DateTime.Parse("1989-6-15"),
                        Genre = "Horror",
                        Price = 9.99M,
                        Rating = "G",
                        Director = "Ivan Reitman",
                        Starring = "Dan Aykroyd, Bill Murray, Sigourney Weaver, Harold Ramis",
                        Description = "The discovery of a massive river of ectoplasm and a resurgence of spectral activity allows the staff of Ghostbusters to revive the business."
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        Image = "Rio Bravo.jpg",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "NA",
                        Director = "Howard Hawks",
                        Starring = "John Wayne, Dean Martin, Ricky Nelson",
                        Description = "A small-town sheriff in the American West enlists the help of a disabled man, a drunk, and a young gunfighter in his efforts to hold in jail the brother of the local bad guy."
                    },

                    new Movie
                    {
                        Title = "Dead Poets Society",
                        Image = "Dead Poets Society.jpg",
                        ReleaseDate = DateTime.Parse("1989-6-2"),
                        Genre = "Drama",
                        Price = 8.56M,
                        Rating = "R",
                        Director = "Peter Weir",
                        Starring = "Robin Williams, Robert Sean Leonard, Ethan Hawke",
                        Description = "Maverick teacher John Keating uses poetry to embolden his boarding school students to new heights of self-expression."
                    },

                    new Movie
                    {
                        Title = "Django",
                        Image = "Django.jpg",
                        ReleaseDate = DateTime.Parse("2012-12-11"),
                        Genre = "Western",
                        Price = 15.25M,
                        Rating = "A",
                        Director = "Quentin Tarantino",
                        Starring = "Jamie Foxx, Christoph Waltz, Leonardo DiCaprio",
                        Description = "With the help of a German bounty-hunter, a freed slave sets out to rescue his wife from a brutal plantation-owner in Mississippi."
                    },

                    new Movie
                    {
                        Title = "Incendies",
                        Image = "Incendies.jpg",
                        ReleaseDate = DateTime.Parse("2010-9-3"),
                        Genre = "War",
                        Price = 4.89M,
                        Rating = "C",
                        Director = "Denis Villeneuve",
                        Starring = "Lubna Azabal, Mélissa Désormeaux-Poulin, Maxim Gaudette",
                        Description = "Twins journey to the Middle East to discover their family history and fulfill their mother's last wishes."
                    },

                    new Movie
                    {
                        Title = "Intouchables",
                        Image = "Intouchables.jpg",
                        ReleaseDate = DateTime.Parse("2011-9-23"),
                        Genre = "Biography",
                        Price = 13.99M,
                        Rating = "B",
                        Director = "Olivier Nakache, Éric Toledano",
                        Starring = "François Cluzet, Omar Sy, Anne Le Ny",
                        Description = "After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver."
                    },

                    new Movie
                    {
                        Title = "Lock, Stock and Two Smoking Barrels",
                        Image = "Lock, Stock and Two Smoking Barrels.jpg",
                        ReleaseDate = DateTime.Parse("1998-8-23"),
                        Genre = "Crime",
                        Price = 7.95M,
                        Rating = "NA",
                        Director = "Guy Ritchie",
                        Starring = "Jason Flemyng, Dexter Fletcher, Nick Moran",
                        Description = "Eddy persuades his three pals to pool money for a vital poker game against a powerful local mobster, Hatchet Harry. Eddy loses, after which Harry gives him a week to pay back 500,000 pounds."
                    },

                    new Movie
                    {
                        Title = "Matrix",
                        Image = "Matrix.jpg",
                        ReleaseDate = DateTime.Parse("1999-3-24"),
                        Genre = "Action",
                        Price = 12.30M,
                        Rating = "G",
                        Director = "Lana Wachowski, Lilly Wachowski",
                        Starring = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
                        Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence."
                    },

                    new Movie
                    {
                        Title = "Pink Floyd The Wall",
                        Image = "Pink Floyd The Wall.jpg",
                        ReleaseDate = DateTime.Parse("1982-5-22"),
                        Genre = "Music",
                        Price = 9.95M,
                        Rating = "R",
                        Director = "Alan Parker",
                        Starring = "Bob Geldof, Christine Hargreaves, James Laurenson",
                        Description = "A confined but troubled rock star descends into madness in the midst of his physical and social isolation from everyone."
                    },

                    new Movie
                    {
                        Title = "Primal Fear",
                        Image = "Primal Fear.jpg",
                        ReleaseDate = DateTime.Parse("1996-4-1"),
                        Genre = "Crime",
                        Price = 15.35M,
                        Rating = "A",
                        Director = "Gregory Hoblit",
                        Starring = "Richard Gere, Laura Linney, Edward Norton",
                        Description = "An altar boy is accused of murdering a priest, and the truth is buried several layers deep."
                    },

                    new Movie
                    {
                        Title = "Room",
                        Image = "Room.jpg",
                        ReleaseDate = DateTime.Parse("2015-9-4"),
                        Genre = "Thriller",
                        Price = 8.95M,
                        Rating = "A",
                        Director = "Lenny Abrahamson",
                        Starring = "Brie Larson, Jacob Tremblay, Sean Bridgers",
                        Description = "Held captive for 7 years in an enclosed space, a woman and her young son finally gain their freedom, allowing the boy to experience the outside world for the first time."
                    },

                    new Movie
                    {
                        Title = "Scream",
                        Image = "Scream.jpg",
                        ReleaseDate = DateTime.Parse("2021-1-13"),
                        Genre = "Horror",
                        Price = 13.99M,
                        Rating = "C",
                        Director = "Matt Bettinelli-Olpin, Tyler Gillett",
                        Starring = "Neve Campbell, Courteney Cox, David Arquette",
                        Description = "25 years after a streak of brutal murders shocked the quiet town of Woodsboro, Calif., a new killer dons the Ghostface mask and begins targeting a group of teenagers to resurrect secrets from the town's deadly past."
                    },

                    new Movie
                    {
                        Title = "Some Like It Hot",
                        Image = "Some Like It Hot.jpg",
                        ReleaseDate = DateTime.Parse("1959-3-29"),
                        Genre = "Comedy",
                        Price = 14.79M,
                        Rating = "NA",
                        Director = "Billy Wilder",
                        Starring = "Marilyn Monroe, Tony Curtis, Jack Lemmon",
                        Description = "After two male musicians witness a mob hit, they flee the state in an all-female band disguised as women, but further complications set in."
                    },

                    new Movie
                    {
                        Title = "The Deer Hunter",
                        Image = "The Deer Hunter.jpg",
                        ReleaseDate = DateTime.Parse("1978-12-8"),
                        Genre = "Drama",
                        Price = 30.90M,
                        Rating = "G",
                        Director = "Michael Cimino",
                        Starring = "Robert De Niro, Christopher Walken, John Cazale",
                        Description = "An in-depth examination of the ways in which the Vietnam War impacts and disrupts the lives of several friends in a small steel mill town in Pennsylvania."
                    },

                    new Movie
                    {
                        Title = "The Eyes of Tammy Faye",
                        Image = "The Eyes of Tammy Faye.jpg",
                        ReleaseDate = DateTime.Parse("2021-9-17"),
                        Genre = "Biography",
                        Price = 32.59M,
                        Rating = "R",
                        Director = "Michael Showalter",
                        Starring = "Jessica Chastain, Andrew Garfield, Cherry Jones",
                        Description = "An intimate look at the extraordinary rise, fall and redemption of televangelist Tammy Faye Bakker."
                    },

                    new Movie
                    {
                        Title = "The Green Mile",
                        Image = "The Green Mile.jpg",
                        ReleaseDate = DateTime.Parse("1999-12-6"),
                        Genre = "Fantasy",
                        Price = 31.99M,
                        Rating = "R",
                        Director = "Frank Darabont",
                        Starring = "Tom Hanks, Michael Clarke Duncan, David Morse",
                        Description = "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift."
                    },

                    new Movie
                    {
                        Title = "The King's Man",
                        Image = "The King's Man.jpg",
                        ReleaseDate = DateTime.Parse("2021-12-22"),
                        Genre = "Action",
                        Price = 24.99M,
                        Rating = "B",
                        Director = "Matthew Vaughn",
                        Starring = "Ralph Fiennes, Gemma Arterton, Rhys Ifans",
                        Description = "In the early years of the 20th century, the Kingsman agency is formed to stand against a cabal plotting a war to wipe out millions."
                    },

                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        Image = "The Shawshank Redemption.jpg",
                        ReleaseDate = DateTime.Parse("1994-9-10"),
                        Genre = "Drama",
                        Price = 38.95M,
                        Rating = "A",
                        Director = "Frank Darabont",
                        Starring = "Tim Robbins, Morgan Freeman, Bob Gunton",
                        Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
                    },

                    new Movie
                    {
                        Title = "Uncharted",
                        Image = "Uncharted.jpg",
                        ReleaseDate = DateTime.Parse("2022-1-10"),
                        Genre = "Adventure",
                        Price = 9.45M,
                        Rating = "B",
                        Director = "Ruben Fleischer",
                        Starring = "Tom Holland, Mark Wahlberg, Antonio Banderas",
                        Description = "Street-smart Nathan Drake is recruited by seasoned treasure hunter Victor Sully Sullivan to recover a fortune amassed by Ferdinand Magellan, and lost 500 years ago by the House of Moncada."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
