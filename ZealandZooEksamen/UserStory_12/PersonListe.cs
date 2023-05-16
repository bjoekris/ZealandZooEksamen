
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

using ZealandZooEksamen.UserStory_12;

//Mathilde//
namespace ZealandZooEksamen.Userstory_12;

    public class PersonListe
    {


         private readonly List<Person> _Personer = new List<Person>()
         {
            new Person(1, "Magnus", "11223344", true),
            new Person(2, "Mathilde", "44332211", true),
            new Person(3, "Kader", "99887766", true),
            new Person(4, "Bjørn", "66778899", true)



            };

        public PersonListe() { }

    


    public Person FindPerson(int id)
    {
        foreach (Person p in _Personer)
        {
            if (p.Id == id)
            {
                return p;
            }
        }
        throw new Exception("Ingen tilmeldte");
    }

    public List<Person> GetAllPersons()
    {
        return new List<Person>(_Personer);
    }

    private readonly List<Person> person = new List<Person>()
    {
        new Person(1, "Magnus", "11223344", true),
        new Person(2, "Mathilde", "44332211", true),
        new Person(3, "Kader", "99887766", true),
        new Person(4, "Bjørn", "66778899", true)
    };

    public void OpretPerson(Person pe)
    {
        _Personer.Add(pe);
    }

    public void SletPerson(int id)
    {
        Person sletPerson = FindPerson(id);
        _Personer.Remove(sletPerson);
    }

}


/*
 * public class Team
{
    // Oprettelse en liste af spillere
    public List<Player> players = new List<Player>();

    // Add metoden
    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    // Metoden GetAverageRating hvor vi bruger Average som er en metode i libary
    public double GetAverageRating()
    {
        return players.Average(player => player.Rating);
    }
}
*/