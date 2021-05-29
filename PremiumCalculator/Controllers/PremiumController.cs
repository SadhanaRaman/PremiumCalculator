using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Services.Interfaces;

namespace PremiumCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiumController : ControllerBase
    {
        private readonly IPremiumService _premiumService;
        public PremiumController(IPremiumService premiumService)
        {
            _premiumService = premiumService;
        }
        /// <summary>
        /// Calculates and Returns the Premium for a given set of Options
        /// </summary>
        /// <param name="cover"></param>
        /// <param name="occupation"></param>
        /// <param name="birthdate"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public double GetPremium(double cover, string occupation, DateTime birthdate)
        {
            //throw new NotImplementedException();
            var premium = _premiumService.CalculatePremium(cover, occupation, birthdate);
            {
                return premium;
            }
        }
    }
}