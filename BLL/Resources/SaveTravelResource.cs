using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace carpoolapp.BLL.Resources {
    public class SaveTravelResource {
        [Required]
        public string StartLocation { get; set; }

        [Required]
        public string EndLocation { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string Info { get; set; }

        [Required]
        public string CarLicensePlate { get; set; }

        public IEnumerable<int> EmployeeIdList { get; set; } = new List<int> ();
    }
}