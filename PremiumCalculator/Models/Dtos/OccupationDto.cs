using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Models.Dtos
{
    public class OccupationDto
    {
        [Required]
        public string Occupation { get; set; }
    }
}
