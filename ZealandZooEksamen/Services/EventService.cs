using ZealandZooEksamen.MockData;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public class EventService : IEventService
    {
        private MockEventListe mockEvents = new MockEventListe();
        private Kalender events = new Kalender();
        public void DeleteEvent(int eventId)
        {
            events.SletEvent(eventId);
        }

        public void DeleteMockEvent(int eventId)
        {
            mockEvents.SletMockEvent(eventId);
        }

        public void CreateEvent(Event ev)
        {
            events.OpretEvent(ev);
        }



        public Event FindEvent(int eventId)
        {
            return events.FindEvent(eventId);
        }

        public Event FindMockEvent(int eventId)
        {
            return mockEvents.FindMockEvent(eventId);
        }

        public List<Event> GetAllEvents()
        {
            return events.GetAllEvents();
        }

        public List<Event> GetAllMockEvents()
        {
            return mockEvents.GetAllMockEvents();
        }

        public void EditEvent(Event newValues)
        {
            events.EditEvent(newValues);
        }
    }
}
