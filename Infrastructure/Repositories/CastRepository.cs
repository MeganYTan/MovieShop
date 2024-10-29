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
    public class CastRepository : BaseRepository<Cast>, ICastRepository
    {
        private readonly MovieShopAppDbContext _context;
        public CastRepository(MovieShopAppDbContext c) : base(c)
        {
            _context = c;
        }
        public override Cast GetById(int id)
        {
            var result = _context.Casts.Include(m => m.MovieCasts)
                .ThenInclude(mc => mc.Movie)
                .FirstOrDefault();
            return result;
        }
    }
}
