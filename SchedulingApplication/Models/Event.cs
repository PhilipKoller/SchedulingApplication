using System;
using System.ComponentModel.DataAnnotations;

namespace SchedulingApplication.Models
{
    public class CustomDateAttribute : RangeAttribute
    {
        public CustomDateAttribute()
          : base(typeof(DateTime),
                 DateTime.Now.ToShortDateString(),
                  DateTime.Now.AddYears(+6).ToShortDateString()
                 
                )
        { }
    }
    public class Event
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please specify an event type")]
        public EventType? EventType { get; set; }

        [Required]
        public Area? Location { get; set; }

        public string Color { get; set; }
        
       [CustomDate]
        public DateTime StartTime { get; set; }

        [CustomDate]
        public DateTime EndTime { get; set; }

        [Required]
        [Range(0, 200, ErrorMessage = "Please enter a number between 0 and 200.")]
        public int NumOfPeople { get; set; }

        [Required(ErrorMessage = "Please provide a point of contact")]
        public string PocRankName { get; set; }

        [Required(ErrorMessage ="Please enter a valid phone number"), Phone]
        public string PocPhoneNumber { get; set; }



        /*
         * radio buttons for saftey vic corpsman wsso saftey vic etc 
         * 
         */

    }
}
