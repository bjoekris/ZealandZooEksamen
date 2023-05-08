using Microsoft.Extensions.Logging;

namespace ZealandZooEksamen.Model
{//Bjørn
    public class Lager
    {

        public int LagerId { get; set; }
        public string LagerNavn { get; set; }
        public double LagerAntal { get; set; }
        public double LagerPris { get; set; }
        public double LagerIndkøbPris { get; set; }


        public Lager() { }

        public Lager(int lagerId, string lagerNavn, double lagerAntal, double lagerPris, double lagerIndkøbPris)
        {
            LagerId = lagerId;
            LagerNavn = lagerNavn;
            LagerAntal = lagerAntal;
            LagerPris = lagerPris;
            LagerIndkøbPris = lagerIndkøbPris;
        }





        public string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{{{nameof(LagerId)}={LagerId.ToString()}, {nameof(LagerNavn)}={LagerNavn}, {nameof(LagerAntal)}={LagerAntal}, " +
                $"{nameof(LagerPris)}={LagerPris.ToString()}, {nameof(LagerIndkøbPris)}={LagerIndkøbPris.ToString()}}}";
        }


        private readonly List<Lager> lageret = new List<Lager>()
        {

        };

        public List<Lager> GetAllLager()
        {
            return new List<Lager>(lageret);
        }

        public void SletLager(int lagerId)
        {
            Lager sletLager = FindLager(lagerId);
            lageret.Remove(sletLager);
        }

        public Lager FindLager(int lagerId)
        {
            foreach (Lager l in lageret)
            {
                if (l.LagerId == lagerId)
                {
                    return l;
                }
            }
            throw new KeyNotFoundException();
        }

        public void OpretLager(Lager la)
        {
            lageret.Add(la);
        }

        public void EditLager(Lager newValuesLager)
        {
            Lager editLager = FindLager(newValuesLager.LagerId);

            editLager.LagerId = newValuesLager.LagerId;
            editLager.LagerNavn = newValuesLager.LagerNavn;
            editLager.LagerAntal = newValuesLager.LagerAntal;
            editLager.LagerPris = newValuesLager.LagerPris;
            editLager.LagerIndkøbPris = newValuesLager.LagerIndkøbPris;


        }

        //internal List<Lager> GetAllLager()
        //{
        //    throw new NotImplementedException();
        //}
    }






}
