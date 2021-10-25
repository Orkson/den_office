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
        [Display(Name = "Usługa")]
        public string Service { get; set; }
        public string Status { get; set; }
        [Display(Name = "Data usługi")]
        [DataType(DataType.Date)]
        public DateTime ServiceDate { get; set; }
        [Display(Name = "Data rezerwacji")]
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }




    }
}
