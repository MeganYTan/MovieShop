using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private readonly MovieShopAppDbContext _context;
        public MovieRepository(MovieShopAppDbContext c) : base(c)
        {
            _context = c;
        }

        public IEnumerable<Movie> GetMoviesWithGenre()
        {
            return _context.Movies.Include(x => x.Genres).ToList();
        }

        public IEnumerable<Movie> GetTopRevenueMovies(int number = 20)
        {
            return _context.Movies.OrderByDescending(x=>x.Revenue).Take(number).Include(x=>x.Genres).ToList(); ;
        }

        IEnumerable<Movie> IMovieRepository.GetHighestGrossingMovies(int number)
        {
            return _context.Movies.OrderByDescending(x=>x.Revenue).Take(number).ToList();
        }

        public override Movie GetById(int id)
        {
            var movie = _context.Movies
            .Include(m => m.MovieGenres) 
                .ThenInclude(mg => mg.Genre) 
            .Include(m => m.MovieCasts) 
                .ThenInclude(mc => mc.Cast) 
            .Include(m => m.Reviews) 
            .FirstOrDefault(m => m.Id == id);

            return movie;
        }
    }
}
