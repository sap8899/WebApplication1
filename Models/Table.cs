using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public string phone { get; set; }
        public string PersonalDetails { get; set; }
        
        [Required(ErrorMessage = "Enter the issued date.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public int NumberOfPeople { get; set; }
        public string Comments { get; set; }
    }
}
