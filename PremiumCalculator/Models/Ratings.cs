using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Models
{
    public class Ratings
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int RatingID { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public float Factor { get; set; }
        public DateTime Created { get; set; }
    }
}
