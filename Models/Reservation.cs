using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace den_office.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public string Status { get; set; }
        [Display(Name = "Data usługi")]
        [DataType(DataType.DateTime)]
        public DateTime ServiceDate { get; set; }
        [Display(Name = "Data rezerwacji")]
        [DataType(DataType.DateTime)]
        public DateTime ReservationDate { get; set; }

        public int ServiceId {get; set;}
        [Display(Name = "Usługa")]
        public Service Service { get; set; }



    }
}
