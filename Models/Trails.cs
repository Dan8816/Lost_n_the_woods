using System;
using System.ComponentModel.DataAnnotations;
namespace lost.Models
{
    public abstract class BaseEntity {}
    public class Trail : BaseEntity
    {
        [Key]
        public int id { get; set; }
 
        [Required]
        [MinLength(3)]
        public string trail_name { get; set; }
 
        [Required]
        [MinLength(10)]
        [MaxLength(140)]
        public string descript { get; set; }

 
        [Required]
        [Range(0,1000)]
        public double length  { get; set; }

        [Required]
        [Range(0,30000)]
        public int elev_change  { get; set; }

        [Required]
        [Range(-90,90)]
        public double lat  { get; set; }
        
        [Required]
        [Range(0,180)]
        public double lon  { get; set; }
    }
}
