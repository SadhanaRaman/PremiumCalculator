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
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<double> FetchPremium(double suminsured, string occupation, DateTime birthdate)
        {
            //Note - In this perticular case it also makes sense to return a Specific type rather than an ActionResult, which is what I had initially.
            try
            {
                var premium = _premiumService.CalculatePremium(suminsured, occupation, birthdate);
             if(premium>=0)
                {
                    return Ok(premium);
                }
                return BadRequest();
            }
            catch
            {
                return NotFound();
            }

        }
    }
}