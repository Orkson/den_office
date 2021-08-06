using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.Employees
{
    public interface IReservationes
    {
        Reservationes GetReservation(int Id);
    }
}
