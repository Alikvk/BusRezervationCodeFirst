using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservationProject.Classes
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }

        public string FirstName { get; set; }
        public string SurName { get; set; }

    }
}
