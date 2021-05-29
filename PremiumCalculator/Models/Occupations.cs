using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Models
{
    public class Occupations
    {
        [Key]
        public int OccupationId { get; set; }
        [Required]
        public string Occupation { get; set; }
        [Required]
        public int RatingID { get; set; }
        public DateTime Created { get; set; }
        public Ratings Ratings { get; set; }
    }
}
