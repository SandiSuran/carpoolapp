using System;

namespace carpoolapp.BLL.Resources
{
    public class TravelResource
    {
        public int ID { get; set; }

        public string StartLocation { get; set; }

        public string EndLocation { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Info { get; set; }
        public string CarLicensePlate { get; set; }

    }
}