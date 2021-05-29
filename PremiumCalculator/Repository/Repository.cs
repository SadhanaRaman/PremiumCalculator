using PremiumCalculator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDBContext _db;
        public Repository(ApplicationDBContext db)
        {
            _db = db;
        }
        public float GetRatingForOccupation(string occupation)
        {
             var ratingFactor = from r in _db.Ratings
                   join o in _db.Occupations on r.RatingID equals o.RatingID
                   where o.Occupation == occupation
                   select r.Factor;
            return ratingFactor.FirstOrDefault();
        }
    }
}
