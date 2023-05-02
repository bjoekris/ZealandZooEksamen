namespace ZealandZooEksamen.Userstory_12
{
  

    public class list<T>
    {

        public list<Person> Tilmeldte = new list<Person>();

        public void AddPerson(Person person)
        {
            Person.Add(person); 
        }


    }
}
