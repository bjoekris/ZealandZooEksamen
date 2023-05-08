using ZealandZooEksamen.Userstory_12;
using ZealandZooEksamen.UserStory_12;

namespace ZealandZooEksamen.Services
{
    public interface IPersonService
    {
        public List<Person> GetAllPerson();


        public void DeletePerson(int id);
        public Person FindPerson(int id);
        public void CreatePerson(Person pe);
    }
}
