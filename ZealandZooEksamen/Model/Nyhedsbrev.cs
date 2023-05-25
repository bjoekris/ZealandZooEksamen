using System.ComponentModel.DataAnnotations;

namespace ZealandZooEksamen.Model
{
    public class Nyhedsbrev
    {
        public int NyhedsbrevId { get; set; }
        public string Navn { get; set; }

        [MaxLength(8)]
        public string Telefon { get; set; }

        public Nyhedsbrev() { }


        public Nyhedsbrev(int nyhedsbrevId, string navn, string telefon)
        {
            NyhedsbrevId = nyhedsbrevId;
            Navn = navn;
            Telefon = telefon;
        }

        public string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"{{{nameof(NyhedsbrevId)}={NyhedsbrevId.ToString()}, {nameof(Navn)}={Navn}, {nameof(Telefon)}={Telefon}}}";
        }


        private readonly List<Nyhedsbrev> tilmeldt = new List<Nyhedsbrev>()
        {

        };

      

        public List<Nyhedsbrev> GetAllNyhedsbrev(Nyhedsbrev nyhedsbrev)
        {
            return new List<Nyhedsbrev>(tilmeldt);
        }

        public void OpretTilmeldte(Nyhedsbrev n)
        {
            tilmeldt.Add(n);
        }


    }
}
