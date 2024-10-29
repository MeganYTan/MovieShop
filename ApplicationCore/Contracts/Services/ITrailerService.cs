using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface ITrailerService
    {
        int AddTrailer(Trailer trailer);
        int UpdateTrailer(Trailer trailer, int id);
        int DeleteTrailer(int id);
        IEnumerable<Trailer> GetAllTrailer();
        Trailer GetTrailerById(int id);
    }
}
