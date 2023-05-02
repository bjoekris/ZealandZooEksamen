

namespace ZealandZooEksamen.Userstory_12
{
    public class MockData : Person
    {
        private readonly List<Person> mockPerson = new List<Person>()
        {
            new Person(1, "Magnus", "11223344", true),
            new Person(2, "Mathilde", "44332211", true),
            new Person(3, "Kader", "99887766", false),
            new Person(4, "Bjørn", "66778899", false)
        };
        public List<Person> GetAll(IEnumerable<Person> mockPerson)
        {
            return new List<Person>(mockPerson);
        }

        public Person FindPerson(bool attending)
        {
            foreach (Person p in mockPerson)
            {
                if (p.Attending == true)
                {
                    return p;
                } 
            }
            throw new Exception("Ingen tilmeldte");
        }
    }
}
