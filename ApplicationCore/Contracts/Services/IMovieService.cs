﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IMovieService
    {
        int AddMovie(Movie movie);
        int UpdateMovie(Movie movie, int id);
        int DeleteMovie(int id);
        IEnumerable<Movie> GetAllMovie();
        Movie GetMovieById(int id);
    }
}
