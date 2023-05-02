using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

//Mathilde//
namespace ZealandZooEksamen.Userstory_12;

    public class Person
    {
        public Person(int id, string name, string phoneNumber, bool attending)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Attending = attending; 
    }
        
        public int Id { get; set; }

 
        public string? Name { get; set; }
        
    
        public string? PhoneNumber { get; set; }

        public bool Attending { get; set; }
    public Person() { }

    internal static void Add(Person person)
    {
        throw new NotImplementedException();
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