using Microsoft.Extensions.Logging;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.MockData
{
    public class MockEventListe : Kalender
    {
        private readonly List<Event> mockEvents = new List<Event>()
        {
            new Event("Mock Data 1","26-04-2023","10:17","10:18",4,1,"Lav delete metode"),
            new Event("Mock Data 2","27-04-2023","10:17","10:19",1,2,"Lav delete metode"),
            new Event("Mock Data 3","27-04-2023","10:41","10:42",3,3,"Lav delete metode"),
            new Event("Mock Data 4","27-04-2023","10:42","10:43",8,4,"Lav delete metode"),
            new Event("Mock Data 5","27-04-2023","10:52","10:53",11,5,"Lav delete metode")
        };
        public List<Event> GetAllMockEvents()
        {
            return new List<Event>(mockEvents);
        }
        public void SletMockEvent(int eventId)
        {
            Event sletMockEvent = FindMockEvent(eventId);
            mockEvents.Remove(sletMockEvent);
        }
        public Event FindMockEvent(int eventId)
        {
            foreach (Event me in mockEvents)
            {
                if (me.EventId == eventId)
                {
                    return me;
                }
            }
            throw new KeyNotFoundException();
        }
    }
}
