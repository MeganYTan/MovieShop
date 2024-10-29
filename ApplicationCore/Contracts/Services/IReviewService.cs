using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IReviewService
    {
        int AddReview(Review review);
        int UpdateReview(Review review, int id);
        int DeleteReview(int id);
        IEnumerable<Review> GetAllReview();
        Review GetReviewById(int id);
    }
}
