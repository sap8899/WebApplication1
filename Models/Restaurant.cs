using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"^[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Category { get; set; }

        [RegularExpression(@"^[0-5]$")]
        [Required]
        public int Rating { get; set; }

        [RegularExpression(@"^[0-9]*$")]
        [Required]
        public int Price { get; set; }
    }
}
