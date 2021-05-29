using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Repository
{
    interface IRepository
    {
        IQueryable<float> GetRatingForOccupation(string Occupation);
    }
}
