using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime Founded { get; set; }
    }
}