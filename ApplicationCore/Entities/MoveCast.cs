using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    [PrimaryKey(nameof(CastId), nameof(MovieId))]
    public class MovieCast
    {
        public int CastId { get; set; }
        public Cast Cast { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string Character { get; set; }
    }

}
