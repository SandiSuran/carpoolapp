using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolapp.Models
{
    public class Car
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string LicensePlate { get; set; }
        public string Name { get; set; }
        public string CarType { get; set; }
        public string Color { get; set; } 
        [Required]
        public int NumberOfSeats { get; set; }
        public string CurrentLocation { get; set; }
        public virtual ICollection<Travel> Travels { get; set; }
    }
}