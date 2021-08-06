using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using den_office.Employees;

namespace den_office.Employees
{
    public class ReservationesController : Controller
    {
        private IReservationes _reservationesRepo;

        public ReservationesController(IReservationes reservationesRepo)
        {
            _reservationesRepo = reservationesRepo;
        }


        public string Index()
        {
            return _reservationesRepo.GetReservation(1).Service;
        }
        public JsonResult Details(int Id)
        {
            Reservationes model = _reservationesRepo.GetReservation(Id);
            return Json(model);
        }
    }
}
