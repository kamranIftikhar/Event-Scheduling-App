using System;
using System.ComponentModel.DataAnnotations;

namespace EventScheduler.Models
{
    public class EventModel
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public string Location { get; set; }
    }
}
