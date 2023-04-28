using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public interface IEventService
    {
        public List<Event> GetAllEvents();
        public void DeleteEvent(int eventId);
        public Event FindEvent(int eventId);
        public void CreateEvent(int eventId);
        
    }
}
