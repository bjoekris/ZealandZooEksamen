using ZealandZooEksamen.Userstory_12;
namespace ZealandZooEksamen.Services
{
    public interface IPersonService
    {
        public List<PersonListe> GetAllPerson();
        public void DeletePerson(int id);
        public PersonListe FindPerson(int id);
        public void CreatePerson(PersonListe pe);
    }
}
