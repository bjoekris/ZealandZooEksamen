namespace ZealandZooEksamen.UserStory_12
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public bool Attending { get; set; }

        public Person(int id, string name, string phoneNumber, bool attending)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Attending = attending;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(PhoneNumber)}={PhoneNumber}, {nameof(Attending)}={Attending.ToString()}}}";
        }
    }
    
}
