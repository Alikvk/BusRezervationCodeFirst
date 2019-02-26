using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservationProject.Classes
{
    public class Trip
    {
        public Trip()
        {
            this.TripPassengerInfo = new HashSet<TripPassengerInfo>();
        }
        [Key]
        public int TripId { get; set; }
        public virtual City DepartureCity { get; set; }
        public virtual City DestinationCity { get; set; }
        public virtual Bus Bus { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<TripPassengerInfo> TripPassengerInfo { get; set; }// Bir yolculuk için birden fazla yolcu bulundurabilir


    }
}
