using den_office.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.ViewModels
{
    public class ReservationViewModel
    {
        public Reservation Reservations { get; set; }
        public IEnumerable<Reservation> ListOfDates { get; set; }
    }
}
