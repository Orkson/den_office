using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using den_office.Data;
using den_office.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using den_office.ViewModels;
using System.Data;
using System.Dynamic;

namespace den_office.Controllers
{
    public class ReservationsController : Controller
    {
        
        private readonly ILogger<ReservationsController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _context;

        public ReservationsController(ApplicationDbContext context,
            ILogger<ReservationsController> logger,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            System.Security.Claims.ClaimsPrincipal currentUser = this.User;
            ViewData["currentUse"] = currentUser;

            _context = context;
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;

        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewBag.ResSortParm = String.IsNullOrEmpty(sortOrder) ? "res_desc" : "";
            ViewBag.ServiceSortParm = sortOrder == "service" ? "service_desc" : "service";
            
            //var model =  await _context.Reservation.Include(e => e.Service).ToListAsync();
            if (sortOrder == "res_desc")
            {
                ViewBag.model = await _context.Reservation.OrderByDescending(s => s.ReservationDate).Include(e => e.Service).ToListAsync();
            }
            else if (sortOrder == "service")
            {
                ViewBag.model = await _context.Reservation.OrderBy(s => s.ServiceDate).Include(e => e.Service).ToListAsync();
            }
            else if (sortOrder == "service_desc")
            {
                ViewBag.model = await _context.Reservation.OrderByDescending(s => s.ServiceDate).Include(e => e.Service).ToListAsync();
            }
            else
            {
                ViewBag.model = await _context.Reservation.OrderBy(s => s.ReservationDate).Include(e => e.Service).ToListAsync();
            }

            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ReservationsList()
        {
            ViewData["model"] = await _context.Reservation.OrderBy(s => s.ServiceDate).Include(e => e.Service).ToListAsync();
            
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ReservationsCalendar()
        {
            return View(await _context.Reservation.Include(e => e.Service).ToListAsync());
        }
        

        [HttpGet]
        public async Task<IActionResult> CreateRes()
        {
            var currentTime = DateTime.Now; //Czy potrzebne?
            //ReservationViewModel model = new ReservationViewModel();
            //var model = new Tuple<List<Reservation>, Reservation> (await _context.Reservation.Where(e => e.ReservationDate.Year >= DateTime.Now.Year
            //                                                 && e.ReservationDate.Month >= DateTime.Now.Month
            //                                                 && e.ReservationDate.Day >= DateTime.Now.Day).ToListAsync, _context.Reservation.Include(e => e.Service).ToListAsync());

            var model = await _context.Reservation.Include(e => e.Service).ToListAsync();
            ViewData["ListOfDates"] =  _context.Reservation.Where(e => e.ReservationDate.Year >= DateTime.Now.Year
                                                              && e.ReservationDate.Month >= DateTime.Now.Month
                                                              && e.ReservationDate.Day >= DateTime.Now.Day).ToList();
            var user = await _userManager.GetUserAsync(User);
            var email = user.Email;
            var surname = user.Surname;
            var firstname = user.FirstName;
            ViewData["email"] = email;
            ViewData["surname"] = surname;
            ViewData["firstname"] = firstname;

            //model.Reservations = (from u in _context.Reservation
            //                       join c in _context.Services on u.ReservationId equals c.ServiceId
            //                       select u).FirstOrDefault();
            //model.ListOfDates = await _context.Reservation.Where(e => e.ReservationDate.Year >= DateTime.Now.Year
            //                                                  && e.ReservationDate.Month >= DateTime.Now.Month
            //                                                  && e.ReservationDate.Day >= DateTime.Now.Day)
            //    .Include(e => e.Service)
            //        .ToListAsync();
            return View();
        }


        [HttpPost]
        [AllowAnonymous]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRes([Bind("ReservationId,Status,ServiceDate,ReservationDate,ServiceId,CustomerName,CustomerSurname,CustomerEmail")] Reservation reservation)
        {

            var user = await _userManager.GetUserAsync(User);
           

            var model = await _context.Reservation.Include(e => e.Service).ToListAsync();

            if (ModelState.IsValid)
            {
                
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

            return View(reservation);


        }




        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.Include(e => e.Service)
                .FirstOrDefaultAsync(m => m.ReservationId == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }


        public async Task<IActionResult> UserInfo()
        {
            var service = await _context.Services.ToListAsync();
            var user = await _userManager.GetUserAsync(User);
            var email = user.Email;
            var variable = user.Surname;

            if (User.IsInRole("Admin")) {
                ViewData["User"] = user;
                ViewData["Variable"] = variable;
                ViewData["Email"] = email;
                ViewData["Service"] = service;

            }
            return View(await _context.Reservation.ToListAsync());
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReservationId,Status,ServiceDate,ReservationDate,ServiceId")] Reservation reservation)
        {
            var user = await _userManager.GetUserAsync(User);
            var email = user.Email;
            var variable = user.Surname;
            ViewData["User"] = user;
            ViewData["Variable"] = variable;
            ViewData["Email"] = email;

            var model = await _context.Reservation.Include(e => e.Service).ToListAsync();

            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }






        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReservationId,Status,ServiceDate,ReservationDate,ServiceId")] Reservation reservation)
        {
            if (id != reservation.ReservationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.ReservationId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .FirstOrDefaultAsync(m => m.ReservationId == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            var reservation = await _context.Reservation.FindAsync(id);
            _context.Reservation.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.ReservationId == id);
        }

            public async Task<IActionResult> Service()
        {
            return View(await _context.Services.ToListAsync());
        }


        

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpGet]
        public async Task<IActionResult> CreateResFinal()
        {
            var model = await _context.Reservation.Include(e => e.Service).ToListAsync();
            var currentTime = DateTime.Now;
            var listOfDates = await _context.Reservation.Where(e => e.ReservationDate.Year >= DateTime.Now.Year
                                                              && e.ReservationDate.Month >= DateTime.Now.Month
                                                              && e.ReservationDate.Day >= DateTime.Now.Day)
                .Include(e => e.Service)
                    .ToListAsync();
            return View(listOfDates);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateResFinal([Bind("ReservationId,Status,ServiceDate,ReservationDate,ServiceId")] Reservation reservation)
        {
            var user = await _userManager.GetUserAsync(User);
            var email = user.Email;
            var variable = user.Surname;
            ViewData["User"] = user;
            ViewData["Variable"] = variable;
            ViewData["Email"] = email;
            var model = await _context.Reservation.Include(e => e.Service).ToListAsync();

            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        



    }
}



