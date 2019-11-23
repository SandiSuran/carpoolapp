using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace carpoolapp.Models {
    public class Employee {
        public int Id { get; set; }

        [Required]
        [StringLength (50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength (50)]
        public string LastName { get; set; }

        public string FullName {
            get {
                return LastName + ", " + FirstName;
            }
        }
        public bool IsDriver { get; set; }
        public virtual ICollection<TravelEmployees> TravelEmployees { get; set; }
    }
}