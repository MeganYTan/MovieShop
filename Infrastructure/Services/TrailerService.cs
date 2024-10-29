using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TrailerService : ITrailerService
    {
        private ITrailerRepository _repository;
        public TrailerService(ITrailerRepository repo)
        {
            _repository = repo;
        }

        public int AddTrailer(Trailer trailer)
        {
            return _repository.Insert(trailer);
        }

        public int DeleteTrailer(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Trailer> GetAllTrailer()
        {
            return _repository.GetAll();
        }

        public Trailer GetTrailerById(int id)
        {
            return _repository.GetById(id);
        }

        public int UpdateTrailer(Trailer trailer, int id)
        {
            if (trailer.Id == id)
            {
                return _repository.Update(trailer);
            }
            return 0;
        }
    }
}
