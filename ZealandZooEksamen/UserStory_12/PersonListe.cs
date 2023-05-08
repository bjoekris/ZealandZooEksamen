//Mathilde//
namespace ZealandZooEksamen.Userstory_12;

public class PersonListe
{
    public PersonListe(int id, string name, string phoneNumber, bool attending)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Attending = attending;
    }

    public int Id { get; set; }


    public string Name { get; set; }


    public string PhoneNumber { get; set; }

    public bool Attending { get; set; }
    public PersonListe() { }

    public PersonListe FindPerson(int id)
    {
        foreach (PersonListe p in person)
        {
            if (p.Id == id)
            {
                return p;
            }
        }
        throw new Exception("Ingen tilmeldte");
    }
    public List<PersonListe> GetAllPersons()
    {
        return new List<PersonListe>();
    }

    private readonly List<PersonListe> person = new List<PersonListe>()
    {
        new PersonListe(1, "Magnus", "11223344", true),
        new PersonListe(2, "Mathilde", "44332211", true),
        new PersonListe(3, "Kader", "99887766", false),
        new PersonListe(4, "Bjørn", "66778899", false)
    };

    public void OpretPerson(PersonListe pe)
    {
        person.Add(pe);
    }

    public void SletPerson(int id)
    {
        PersonListe sletPerson = FindPerson(id);
        person.Remove(sletPerson);
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