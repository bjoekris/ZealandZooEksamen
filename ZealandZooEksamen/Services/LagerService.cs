using ZealandZooEksamen.MockData;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public class LagerService : ILagerService
    {
        private Lager lageret = new Lager();

        public void DeleteLager(int lagerId)
        {
            lageret.SletLager(lagerId);
        }

        public void CreateLager(Lager la)
        {
            lageret.OpretLager(la);
        }

        public Lager FindLager(int lagerId)
        {
            return lageret.FindLager(lagerId);
        }

        public List<Lager> GetAllLager()
        {
            return lageret.GetAllLager();
        }

        public void EditLager(Lager newValuesLager)
        {
            lageret.EditLager(newValuesLager);
        }

        public object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}

