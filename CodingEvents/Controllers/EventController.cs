using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Data;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvents.Controllers
{
    public class EventController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/event/add")]
        public IActionResult Add(string name, string description)
        {
            EventData.Add(new Event(name, description));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (var eventId in eventIds)
                EventData.Remove(eventId);

            return RedirectToAction("Index"); 
        }

    }
}