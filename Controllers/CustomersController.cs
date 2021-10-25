using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using den_office.ViewModels;
using den_office.Data;
using Microsoft.AspNetCore.Authorization;

namespace den_office.Controllers
{
    [Authorize]
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
                                      UserName = user.UserName,
                                      Email = user.Email,
                                  }).ToList();
            return View(customers);
        }
    }
}
