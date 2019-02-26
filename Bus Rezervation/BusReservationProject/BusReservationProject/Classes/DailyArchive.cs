using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservationProject.Classes
{
    public class DailyArchive
    {
        [Key]
        public int DailyArchiveId { get; set; }
        public string Plate { get; set; }
        public DateTime ArchiveDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
