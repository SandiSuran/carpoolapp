using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolapp.Models {
    public class Travel {
        [Key]
        public int ID { get; set; }

        [Required]
        public string StartLocation { get; set; }

        [Required]
        public string EndLocation { get; set; }

        [Column (TypeName = "datetime2")]
        public DateTime StartDate { get; set; }

        [Column (TypeName = "datetime2")]
        public DateTime EndDate { get; set; }

        [Column (TypeName = "ntext")]
        public string Info { get; set; }

        [ForeignKey ("CarLicensePlate")]
        public string CarLicensePlate { get; set; }
        public Car Car { get; set; }
        public virtual ICollection<TravelEmployees> TravelEmployees { get; set; }

    }
}