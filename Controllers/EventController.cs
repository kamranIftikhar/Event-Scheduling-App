using Microsoft.AspNetCore.Mvc;
using EventScheduler.Models;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using System;
using System.IO;
using System.Text; 

namespace EventScheduler.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EventModel model)
        {
            if (ModelState.IsValid)
            {
                var calendarEvent = new CalendarEvent
                {
                    Summary = model.Title,
                    Description = model.Description,
                    Start = new CalDateTime(model.StartTime),
                    End = new CalDateTime(model.EndTime),
                    Location = model.Location,
                    Uid = Guid.NewGuid().ToString()
                };

                var calendar = new Ical.Net.Calendar();
                calendar.Events.Add(calendarEvent);

                var serializer = new CalendarSerializer();
                var serializedCalendar = serializer.SerializeToString(calendar);

                var byteArray = Encoding.UTF8.GetBytes(serializedCalendar);
                var stream = new MemoryStream(byteArray);

                return File(stream, "text/calendar", "event.ics");
            }
            return View("Index");
        }
    }
}