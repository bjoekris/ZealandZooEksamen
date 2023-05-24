using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public interface INyhedsbrevService
    {
        public List<Nyhedsbrev> GetAllNyhedsbrev();

    
        public Nyhedsbrev CreateNyhedsbrev(Nyhedsbrev nyhedsbrev);
        
    }
}
