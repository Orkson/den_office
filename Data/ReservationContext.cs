using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using den_office.Models;


namespace den_office.Data
{
    public class ReservationContext : DbContext
    {
      
        
        public ReservationContext (DbContextOptions<ReservationContext> options)
            : base(options)
        { }


        public DbSet<Reservation> Reservation { get; set; }
        


    }
}
