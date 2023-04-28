namespace ZealandZooEksamen.Model
{
    public class Kalender
    {
        private List<Event> events = new List<Event>()
        {
            new Event("Lav delete metode","26-04-2023","10:17","10:18",5,4,1,"Mock Data")
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

        internal void OpretEvent(int eventId)
        {
            throw new NotImplementedException();
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
