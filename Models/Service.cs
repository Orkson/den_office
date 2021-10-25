using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }

        public int ServiceDuration { get; set; }
    }
}
