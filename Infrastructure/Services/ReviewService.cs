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
    public class ReviewService : IReviewService
    {
        private IReviewRepository _repository;
        public ReviewService(IReviewRepository repo)
        {
            _repository = repo;
        }

        public int AddReview(Review review)
        {
            return _repository.Insert(review);
        }

        public int DeleteReview(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Review> GetAllReview()
        {
            return _repository.GetAll();
        }

        public Review GetReviewById(int id)
        {
            return _repository.GetById(id);
        }

        public int UpdateReview(Review review, int id)
        {
            if (review.Id == id)
            {
                return _repository.Update(review);
            }
            return 0;
        }
    }
}
