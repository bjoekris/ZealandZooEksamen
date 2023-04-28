using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public interface IEventService
    {
        public List<Event> GetAllEvents();
        public List<Event> GetAllMockEvents();
        public void DeleteEvent(int eventId);
        public void DeleteMockEvent(int eventId);
        public Event FindEvent(int eventId);
        public Event FindMockEvent(int eventId);
        public void CreateEvent(int eventId);
        
    }
}
