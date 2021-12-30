using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.Models
{
    public class Service
    {
        public int ServiceId { get; set; }

        [Display(Name = "Usługa")]
        public string ServiceName { get; set; }

        [Display(Name = "Czas usługi")]

        public int ServiceDuration { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
