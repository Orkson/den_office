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

        [Display(Name = "Imię")]
        public string CustomerName { get; set; }

        [Display(Name = "Nazwisko")]
        public string CustomerSurname { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }


        public int ServiceId { get; set; }
        [Display(Name = "Usługa")]
        public Service Service { get; set; }


    }


}
