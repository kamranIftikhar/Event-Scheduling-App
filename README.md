**Event Scheduling App with ICS File Support**

Description:

The Event Scheduling App allows users to create events and download .ics (iCalendar) files for those events, which can be integrated with external calendar apps like Google Calendar or Outlook.

Features:

Create events with a title, description, start time, end time, and location.

Generate and download .ics files for the created events.

Users can import the .ics file into their calendar.

Tech Stack:

Frontend: HTML, Bootstrap for UI design

Backend: ASP.NET Core MVC, Ical.Net for generating .ics files

Deployment: Compatible with Azure, AWS, or any .NET-supported hosting platforms.

Running Locally:

Install the Ical.Net NuGet package:

bash

Copy code

Install-Package Ical.Net

Run the application in Visual Studio.

Navigate to the event creation page and create an event. An .ics file will be generated and ready for download.
