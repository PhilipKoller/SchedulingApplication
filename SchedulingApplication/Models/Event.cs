using System;
using System.ComponentModel.DataAnnotations;

namespace SchedulingApplication.Models
{
    public class Event
    {
        public int ID { get; set; }

        [Required]
        public EventType? EventType { get; set; }

        [Required]
        public Area? Location { get; set; }

        [Range(typeof(DateTime), "1/2/2004", "3/4/2019",
      ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime StartTime { get; set; }

        [Range(typeof(DateTime), "1/2/2004", "3/4/2019",
       ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime EndTime { get; set; }

      [Required]
        public int NumOfPeople { get; set; }

        public string  Poc { get; set; }


        /*
         * radio buttons for saftey vic corpsman wsso saftey vic etc 
         * 
         */

    }
}
