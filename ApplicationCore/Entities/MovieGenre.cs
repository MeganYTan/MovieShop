﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    [PrimaryKey(nameof(GenreId), nameof(MovieId))]
    public class MovieGenre
    {
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }

}
