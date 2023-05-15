using ZealandZooEksamen.Userstory_12;
using ZealandZooEksamen.UserStory_12;

namespace ZealandZooEksamen.Services
{
    public class PersonService : IPersonService
    {

        private readonly PersonListe liste = new PersonListe();


        public void CreatePerson(Person pe)
        {
           liste.OpretPerson(pe);
        }

        public void DeletePerson(int id)
        {
            liste.SletPerson(id);
        }

        public Person FindPerson(int id)
        {
            return liste.FindPerson(id);
        }

        public List<Person> GetAllPerson()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPersons()
        {
            return liste.GetAllPersons();
        }

      
    }
}
