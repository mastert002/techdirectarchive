using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AccessBankPortal.Models;
using AccessBankPortal.Repository;
using Microsoft.AspNetCore.Cors;

namespace AccessBankPortal.Controllers
{
    [EnableCors()]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  IMainRepository _registrationRepo;

        public HomeController(ILogger<HomeController> logger, IMainRepository registrationRepo)
        {
            _logger = logger;
            _registrationRepo = registrationRepo;
        }

      
        public IActionResult Index()
        {
            return View();
        }
        [Route("RegisterComplete")]
        public IActionResult RegisterComplete()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Registration registration)
        {
            if (ModelState.IsValid)
            {
                _registrationRepo.Add<Registration>(registration);
                if (await _registrationRepo.SaveAll())
                        return RedirectToAction("RegisterComplete");

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
