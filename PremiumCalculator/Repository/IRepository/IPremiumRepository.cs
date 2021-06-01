using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Repository
{
    public interface IPremiumRepository
    {
        float GetRatingForOccupation(string Occupation);
    }
}
