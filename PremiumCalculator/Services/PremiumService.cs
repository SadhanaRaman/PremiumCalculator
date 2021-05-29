using PremiumCalculator.Repository;
using PremiumCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Services
{
    public class PremiumService : IPremiumService
    {
        private readonly IRepository _repository;

        //Inject the Repository as a dependency
        public PremiumService(IRepository repository)
        {
            _repository = repository;
        }
        public double CalculatePremium(double cover, string occupation, DateTime birthdate)
        {
            double premium;
            int age = GetAge(birthdate);
            //Get the rating factor from the database
            var ratingFactor = _repository.GetRatingForOccupation(occupation);
            
            //calculate the premium from the given formula and return
            premium = (cover * ratingFactor * age) / (1000 * 12);

            return premium;
        }

        int GetAge (DateTime birthdate)
        { 
            // Getting current Date
            var currentDate = DateTime.Today;
            // Subtract Date of Birth from current date
            var age = currentDate.Year - birthdate.Year;
            // In case of a leap year, go back to the year of bith
            if (birthdate.Date > currentDate.AddYears(-age)) age--;

            return age;
        }
    }
}
