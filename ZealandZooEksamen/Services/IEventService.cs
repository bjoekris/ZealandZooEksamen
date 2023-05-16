using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public interface IEventService
    {

        public List<Event> GetAllEvents();
        public List<Event> GetAllMockEvents();
        public Event DeleteEvent(int eventId);
        public Event DeleteMockEvent(int eventId);
        public Event FindEvent(int eventId);
        public Event FindMockEvent(int eventId);
        public Event CreateEvent(Event ev);
        public Event EditEvent(int eventId, Event events);
    }
}
