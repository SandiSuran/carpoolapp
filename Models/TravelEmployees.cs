
using System.ComponentModel.DataAnnotations.Schema;

namespace carpoolapp.Models
{
    public class TravelEmployees
    {
        public int TravelId { get; set; }
        public int EmployeeId { get; set; }
        
        [ForeignKey("TravelId")]
        public virtual Travel Travel {get; set;}
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee {get; set;} 
    }
}