using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JeffreyJacaEnterpriseAssignment1.Models;

namespace JeffreyJacaEnterpriseAssignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestForm(Request request)
        {
            if (ModelState.IsValid)
            {
                RequestRepository.AddRequest(request);
                return View("Confirmation", request);
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult AllEquipment()
        {
            return View(EquipmentRepository.GetInitialEquipment());
        }

        public IActionResult AvailableEquipment()
        {
            return View(EquipmentRepository.GetInitialEquipment().Where(e => e.Availability == true));
        }

        public IActionResult Requests()
        {
            return View(RequestRepository.Requests);
        }

        public IActionResult RequestDetails(int id)
        {
            var requests = RequestRepository.Requests;
            var req = requests.SingleOrDefault(r => r.Id == id);

            if(req == null)
            {
                return View("Index");
            }

            return View(req);
        }
    }
}