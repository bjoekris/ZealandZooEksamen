namespace ZealandZooEksamen.Model
{
    public class Tilmeldte
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public int Telefon { get; set; }


        public Tilmeldte() { }


        public Tilmeldte(int id, string navn, int telefon) 
        {
            Id = id;
            Navn = navn;
            Telefon = telefon;
        }

        public string GetInfo()
        { 
            return ToString();
        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Telefon)}={Telefon.ToString()}}}";
        }

        private readonly List<Tilmeldte> tilmeldt = new List<Tilmeldte>();


        public List<Tilmeldte> GetAllTilmeldte()
        {
            return new List<Tilmeldte>(tilmeldt);
        }


        public Tilmeldte FindTilmeldte(int id)
        {
            foreach (Tilmeldte t in tilmeldt)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            throw new KeyNotFoundException();
        }

        public void OpretTilmeldte(Tilmeldte t)
        {
            tilmeldt.Add(t);
        }
    }
}
