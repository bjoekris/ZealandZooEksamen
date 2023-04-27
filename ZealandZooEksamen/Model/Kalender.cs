namespace ZealandZooEksamen.Model
{
    public class Kalender
    {
        private List<Event> events = new List<Event>()
        {
            new Event("Lav delete metode","26-04-2023","10:17","10:18",4,4,1,"Mock Data")
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
    }
}
