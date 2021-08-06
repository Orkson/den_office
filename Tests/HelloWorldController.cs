using den_office.Tests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace den_office.Controllers
{
    public class HelloWorldController : Controller
    {

        private IGameData _gamesData;
        public HelloWorldController(IGameData gameData)
        {
            _gamesData = gameData;
        }
        public IActionResult Index()
        {
            var result = _gamesData.GetAll();

            HelloWorldViewModel helloWorldViewModel = new HelloWorldViewModel
            {
                Id = 1,
                Text = "agehujrguihorgrghiougrhohgroijuhrgo;soh;gir"
            };

            return View(result);
        }

    }
}
