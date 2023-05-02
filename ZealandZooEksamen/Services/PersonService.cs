using ZealandZooEksamen.Userstory_12;

namespace ZealandZooEksamen.Services
{
    public class PersonService : IPersonService
    {
        public void CreatePerson(PersonListe pe)
        {
           _person.OpretPerson(pe);
        }

        public void DeletePerson(int id)
        {
            _person.SletPerson(id);
        }

        public PersonListe FindPerson(int id)
        {
            return _person.FindPerson(id);
        }

        public List<PersonListe> GetAllPerson()
        {
            return _person.GetAllPersons();
        }

        private PersonListe _person = new PersonListe();  

    }
}
