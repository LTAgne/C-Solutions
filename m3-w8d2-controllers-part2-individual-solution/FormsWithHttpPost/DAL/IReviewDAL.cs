using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsWithHttpPost.DAL
{
    public interface IReviewDAL
    {
        List<Review> GetAllReviews();
        bool SaveReview(Review newReview);
    }
}
