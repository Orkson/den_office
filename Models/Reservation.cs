using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace den_office.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Status { get; set; }
        [DataType(DataType.Date)]
        public DateTime ServiceDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }




    }
}
