using Microsoft.AspNetCore.Mvc;
using SchedulingApplication.Models;
using SchedulingApplication.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace SchedulingApplication.Controllers
{
    [Authorize]
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
                
                if (eEvent.EventType == EventType.PT)
                {
                    eEvent.Color = "Blue";
                    _eventRepository.Add(eEvent);
                }
                else if (eEvent.EventType == EventType.SQBASIC || eEvent.EventType == EventType.SQINTERMEDIATE)
                {
                    eEvent.Color = "Green";
                    _eventRepository.Add(eEvent);
                }
                else if (eEvent.EventType == EventType.WSA)
                {
                    eEvent.Color = "Purple";
                    _eventRepository.Add(eEvent);
                }
                else if(eEvent.EventType == EventType.OTHER)
                {
                    eEvent.Color = "Black";
                    _eventRepository.Add(eEvent);
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            IEnumerable<Event> events = _eventRepository.GetAllEvents();

            var enumEvent = events.Select(e => e.EventType.Value);


            var eEvents = events.Select(e => new
            {
                id = e.ID,
                title = e.EventType.ToString() + " | " + e.NumOfPeople + "PAX" + " | POC: " + e.PocRankName,
                start = e.StartTime.ToString("yyyy-MM-ddTHH:mm"),
                end = e.EndTime.ToString("yyyy-MM-ddTHH:mm"),
                numberOfPeople = e.NumOfPeople,
                color = e.Color,
                location = e.Location,
                PocRankName = e.PocRankName,
                PocPhoneNumber = e.PocPhoneNumber


            });

            return new JsonResult(eEvents);
           

        }    

        
    }
}
