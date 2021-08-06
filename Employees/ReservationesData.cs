using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.Employees
{
    public class ReservationesData : IReservationes
    {
        private List<Reservationes> _reservationes;
        public ReservationesData()
        {
            _reservationes = new List<Reservationes>()
            {
                new Reservationes(){Id = 1, Service = "Jakas usluga1", Status = "zatwierdzna"},
            };
        }

        public Reservationes GetReservation(int Id)
        {
            return _reservationes.FirstOrDefault(e=>e.Id == Id);
        }

        
    }
}
