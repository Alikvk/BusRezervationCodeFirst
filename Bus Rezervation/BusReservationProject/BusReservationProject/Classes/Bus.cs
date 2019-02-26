using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservationProject.Classes
{
    public class Bus
    {
        [Key]
        public int BusId { get; set; }
        public string Name { get; set; }
        public string Plate { get; set; }
        public int SeatCount { get; set; }
        public byte[] Image  { get; set; }
        [Index(IsUnique =true)] // Bir sürücü bir otobüsü sürebilir
        public Driver Driver { get; set; }
    }
}
