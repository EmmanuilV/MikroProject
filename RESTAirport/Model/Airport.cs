using System;
using System.ComponentModel.DataAnnotations;

namespace MyAirport.Models
{
    public class Airport
    {
        [Key]
        public string Code { get; set; }
        
        public string Title { get; set; }
    }
}