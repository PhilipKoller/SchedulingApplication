using Microsoft.AspNetCore.Mvc;
using SchedulingApplication.Models;
using SchedulingApplication.ViewModels;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc.Rendering;
namespace SchedulingApplication.Controllers
{
    public class CalendarController : Controller
    {
        private IEventRepository _eventRepository;
        public CalendarController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
          
        }
        [HttpGet]
        public IActionResult Event()
        {
            Event eEvent = new Event();
            return View(eEvent);
        }

        [HttpPost]
        public IActionResult Event(Event eEvent)
        {

            if (ModelState.IsValid)
            {
                _eventRepository.Add(eEvent);
            }

            return View();
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            IEnumerable<Event> events = _eventRepository.GetAllEvents();

            var eEvents = events.Select(e => new {
            id = e.ID , 
            title = e.EventType.ToString(),
            start = e.StartTime.ToString("yyyy-MM-ddTHH:mm"),
            end = e.EndTime.ToString("yyyy-MM-ddTHH:mm"),
            numberOfPeople = e.NumOfPeople,
            location = e.Location,
            Poc = e.Poc,

            
            });
            return new JsonResult(eEvents);

        }
    }
}
