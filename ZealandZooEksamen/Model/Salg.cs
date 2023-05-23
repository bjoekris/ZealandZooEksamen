namespace ZealandZooEksamen.Model
{
    public class Salg
    {


        public int SalgsId { get; set; }
        public string SalgsNavn { get; set; }
        public double SalgsAntal { get; set; }
        public double SalgsPris { get; set; }


        public Salg() { }

        public Salg(int salgsId, string salgsNavn, double salgsAntal, double salgsPris)
        {
            SalgsId = salgsId;
            SalgsNavn = salgsNavn;
            SalgsAntal = salgsAntal;
            SalgsPris = salgsPris;
        }

        

        public string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{{{nameof(SalgsId)}={SalgsId.ToString()}, {nameof(SalgsNavn)}={SalgsNavn}, {nameof(SalgsAntal)}={SalgsAntal.ToString()}, {nameof(SalgsPris)}={SalgsPris.ToString()}}}";
        }




        private readonly List<Salg> salget = new List<Salg>()
        {

        };

        public List<Salg> GetAllSalg()
        {
            return new List<Salg>(salget);
        }

        public void SletSalg(int salgsId)
        {
            Salg sletSalg = FindSalg(salgsId);
            salget.Remove(sletSalg);
        }

        public Salg FindSalg(int salgsId)
        {
            foreach (Salg s in salget)
            {
                if (s.SalgsId == salgsId)
                {
                    return s;
                }
            }
            throw new KeyNotFoundException();
        }

        public void OpretSalg(Salg sa)
        {
            salget.Add(sa);
        }

        public void EditSalg(Salg newValuesSalg)
        {
            Salg editSalg = FindSalg(newValuesSalg.SalgsId);

            editSalg.SalgsId = newValuesSalg.SalgsId;
            editSalg.SalgsNavn = editSalg.SalgsNavn;
            editSalg.SalgsAntal = newValuesSalg.SalgsAntal;
            editSalg.SalgsPris = newValuesSalg.SalgsPris;
        }

        //internal List<Lager> GetAllLager()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

