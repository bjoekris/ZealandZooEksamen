﻿using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public class EventService : IEventService
    {
        private Kalender events = new Kalender();
        public void DeleteEvent(int eventId)
        {
            events.SletEvent(eventId);
        }

        public Event FindEvent(int eventId)
        {
            return events.FindEvent(eventId);
        }

        public List<Event> GetAllEvents()
        {
            return events.GetAllEvents();
        }
    }
}
