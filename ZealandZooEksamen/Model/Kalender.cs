namespace ZealandZooEksamen.Model
{

    //Magnus
    public class Kalender
    {
        private readonly List<Event> events = new List<Event>()
        {
            new Event("Mock Event","2023-06-14","00:00","23:59",25,-1,"Magnus' Fødselsdag")
        };
        
        public List<Event> GetAllEvents()
        {
            return new List<Event> (events);
        }
        
        public void SletEvent(int eventId)
        {
            Event sletEvent = FindEvent(eventId);
            events.Remove(sletEvent);
        }
        
        public Event FindEvent(int eventId) 
        {
            foreach (Event e in events)
            {
                if (e.EventId == eventId)
                {
                    return e;
                }
            }
            throw new KeyNotFoundException();
        }

        public void OpretEvent(Event ev)
        {
            events.Add(ev);
        }

        public void EditEvent(Event newValues)
        {
            Event editEvent = FindEvent(newValues.EventId);

            editEvent.Navn = newValues.Navn;
            editEvent.EventInfo = newValues.EventInfo;
            editEvent.Dato = newValues.Dato;
            editEvent.TimeStart = newValues.TimeStart;
            editEvent.TimeEnd = newValues.TimeEnd;
            editEvent.MaksDeltagere = newValues.MaksDeltagere;
        }
    }
}
