using Microsoft.AspNetCore.Mvc.Rendering;
using SchedulingApplication.Models;
using System;
using System.Collections.Generic;

namespace SchedulingApplication.ViewModels
{
    public class CalendarEventViewModel
    {
        public Event eEvent { get; set; }
        public IEnumerable<Event> Events { get; set; }

       
    }
}
