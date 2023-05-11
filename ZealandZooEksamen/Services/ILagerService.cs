using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{//Bjørn
    public interface ILagerService
    { 
        public List<Lager> GetAllLager();
       
        public void DeleteLager(int lagerId);
    
        public Lager FindLager(int lagerId);
      
        public void CreateLager(Lager la);

        public void EditLager(Lager newValuesLager);



        object Where(Func<object, bool> value);
    }
}
