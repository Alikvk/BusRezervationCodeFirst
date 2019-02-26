using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservationProject.Classes
{
    public class TripPassengerInfo
    {
        [Key]
        public int TripPassengerId { get; set; }
        public int TripId { get; set; }
        public virtual Passenger Passenger { get; set; }
        public int SeatNumber { get; set; }
    }
}
