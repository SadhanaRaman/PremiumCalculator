using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Services.Interfaces
{
    public interface IPremiumService
    {
       double CalculatePremium(double cover, string occupation, DateTime birthdate);
    }
}
