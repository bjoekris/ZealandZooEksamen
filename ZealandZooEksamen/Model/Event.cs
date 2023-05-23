namespace ZealandZooEksamen.Model
{

    //Magnus
    public class Event
    {
        public string Navn { get; set; }
        public string Dato { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public double MaksDeltagere { get; set; }
        public double AntalDeltagere { get { return Tilmeldte.Count; } }
        public int EventId { get; set; }
        public string EventInfo { get; set; }

        public List<string> Tilmeldte { get; set; }


        public Event() { Tilmeldte = new List<string>(); }

        public Event(string navn, string dato, string timeStart, string timeEnd, double maksDeltagere, 
            int eventId, string eventInfo)
        {
            Navn = navn;
            Dato = dato;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            MaksDeltagere = maksDeltagere;
            EventId = eventId;
            EventInfo = eventInfo;
            Tilmeldte = new List<string>();
        }

        public string GetInfo()
        {
            return ToString();
        }
        public override string ToString()
        {
            return $"{nameof(Navn)}={Navn}, {nameof(Dato)}={Dato}, {nameof(TimeStart)}={TimeStart}, " +
                $"{nameof(TimeEnd)}={TimeEnd}, {nameof(MaksDeltagere)}={MaksDeltagere.ToString()}, " +
                $"{nameof(AntalDeltagere)}={AntalDeltagere.ToString()}, {nameof(EventId)}={EventId.ToString()}, " +
                $"{nameof(EventInfo)}={EventInfo}";
        }
    }
}
