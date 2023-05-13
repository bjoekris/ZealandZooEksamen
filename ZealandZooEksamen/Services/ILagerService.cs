using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{//Bjørn
    public interface ILagerService
    { 
        public List<Lager> GetAllLager();
       
        public Lager DeleteLager(int lagerId);
    
        public Lager FindLager(int lagerId);
      
        public Lager CreateLager(Lager la);

        public Lager EditLager(int lagerId, Lager Lager);
        
        
    }
}
