

namespace ZealandZooEksamen.Userstory_12;

    public class MockData : PersonListe
    {
        private readonly List<PersonListe> mockPerson = new List<PersonListe>()
        {
            new PersonListe(1, "Magnus", "11223344", true),
            new PersonListe(2, "Mathilde", "44332211", true),
            new PersonListe(3, "Kader", "99887766", false),
            new PersonListe(4, "Bjørn", "66778899", false)
        };
        public List<PersonListe> GetAll(IEnumerable<PersonListe> mockPerson)
        {
            return new List<PersonListe>(mockPerson);
        }

      
    }
