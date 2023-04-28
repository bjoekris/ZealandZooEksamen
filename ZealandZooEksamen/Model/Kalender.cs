namespace ZealandZooEksamen.Model
{
    public class Kalender
    {
        private readonly List<Event> events = new List<Event>()
        {
            
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
    }
}
