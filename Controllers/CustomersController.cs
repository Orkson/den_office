using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using den_office.ViewModels;
using den_office.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace den_office.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            //var allUsers = _context.Users.ToList();
            //return View(allUsers);
            var customers = (from user in _context.Users
                                  select new CustomersViewModel()
                                  {
                                      FirstName = user.FirstName,
                                      Surname = user.Surname,
                                      PhoneNumber = user.PhoneNumber,
                                      Email = user.Email,
                                  }).ToList();
            return View(customers);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerdetails = await _context.Reservation.Include(e => e.Service)
                .FirstOrDefaultAsync(m => m.ReservationId == id);
            if (customerdetails == null)
            {
                return NotFound();
            }

            return View(customerdetails);
        }
    }
}
