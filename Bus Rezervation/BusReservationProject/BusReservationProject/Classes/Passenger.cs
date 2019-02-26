using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservationProject.Classes
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
