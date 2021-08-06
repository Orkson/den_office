using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.Employees
{
    public class Reservationes
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Status { get; set; }
        [DataType(DataType.Date)]
        public DateTime ServiceDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }

        public IEnumerable<Reservationes> ReturnAll()
        {
            return ReturnAll();
        }

    }
}
