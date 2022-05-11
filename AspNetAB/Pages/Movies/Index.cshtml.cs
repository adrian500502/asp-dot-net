using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetAB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetAB.Pages.Movies
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly AspNetAB.Models.AuthDbContext _context;

        public IndexModel(AspNetAB.Models.AuthDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public SelectList Ratings { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieRating { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            // The following code is a LINQ query that retrieves all the genres from the database.
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            IQueryable<string> ratingQuery = from m in _context.Movie
                                             orderby m.Rating
                                             select m.Rating;

            var movies = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            if (!string.IsNullOrEmpty(MovieRating))
            {
                movies = movies.Where(x => x.Rating == MovieRating);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync()); // The SelectList of genres is created by projecting the distinct genres.
            Ratings = new SelectList(await ratingQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
