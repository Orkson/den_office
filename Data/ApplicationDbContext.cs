using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using den_office.Models;
using den_office.Tests;


namespace den_office.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

  

        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Service> Services { get; set; }


        public DbSet<den_office.Tests.Game> Game { get; set; }
    }
    
}




