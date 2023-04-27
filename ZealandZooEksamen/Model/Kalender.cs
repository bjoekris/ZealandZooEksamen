namespace ZealandZooEksamen.Model
{
    public class Kalender
    {
        private readonly List<Event> events = new List<Event>()
        {
            new Event("Mock Data 1","26-04-2023","10:17","10:18",4,4,1,"Lav delete metode"),
            new Event("Mock Data 2","27-04-2023","10:17","10:19",1,1,2,"Lav delete metode"),
            new Event("Mock Data 3","27-04-2023","10:41","10:32",2,3,3,"Lav delete metode"),
            new Event("Mock Data 4","27-04-2023","10:42","10:43",4,8,4,"Lav delete metode"),
            new Event("Mock Data 5","27-04-2023","10:52","10:53",5,11,5,"Lav delete metode")
        };
        public List<Event> GetAllEvents()
        {
            return events;
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
