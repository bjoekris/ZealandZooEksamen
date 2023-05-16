using DocumentFormat.OpenXml.Drawing.Charts;
using System.Data.SqlClient;
using ZealandZooEksamen.MockData;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public class EventService : IEventService
    {
        private const String ConnectionString = "Data Source = mssql5.unoeuro.com; Initial Catalog = bbksolutions_dk_db_databasen; User ID = bbksolutions_dk; Password=cmfbeAtrkR5zBaF426x3;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent = ReadWrite; MultiSubnetFailover=False\r\n";

        private Kalender events = new Kalender();

        public Event DeleteEvent(int eventId)
        {
            Event e = FindEvent(eventId);
            if (e is null)
            {
                return null;
            }

            String sql = "delete from Event where EventId = @EventId";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EventId", eventId);

                int row = cmd.ExecuteNonQuery();

            if(row == 1)
            {
                return e;
            }
            else
            {
                return null;
            }
        }

        public Event DeleteMockEvent(int eventId)
        {
            Event me = FindMockEvent(eventId);
            if (me is null)
            {
                return null;
            }

            String sql = "delete from MockEvent where EventId = @EventId";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EventId", eventId);

            int row = cmd.ExecuteNonQuery();

            if (row == 1)
            {
                return me;
            }
            else
            {
                return null;
            }
        }

        //events.SletEvent(eventId);
        //mockEvents.SletMockEvent(eventId);

        public Event CreateEvent(Event ev)
        {
            String sql = "insert into Event values(@Navn, @Dato, @TimeStart, @TimeEnd, @MaksDeltagere, @TilmeldingId, @EventInfo)";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Navn", ev.Navn);
            cmd.Parameters.AddWithValue("@Dato", ev.Dato);
            cmd.Parameters.AddWithValue("@TimeStart", ev.TimeStart);
            cmd.Parameters.AddWithValue("@TimeEnd", ev.TimeEnd);
            cmd.Parameters.AddWithValue("@MaksDeltagere", ev.MaksDeltagere);
            //cmd.Parameters.AddWithValue("@TilmeldingId", ); //Skal add en foreign key, men ved ikke hvordan.
            cmd.Parameters.AddWithValue("@EventInfo", ev.EventInfo);

            int row = cmd.ExecuteNonQuery();

            if(row == 1)
            {
                return ev;
            }
            else
            {
                return null;
            }
        }
        
        //events.OpretEvent(ev);
        
        public Event FindEvent(int eventId)
        {
            String sql = "select * from Event where EventId = @EventId";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EventId", eventId);

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                return ReadEvent(reader);
            }
            return null;
        }

        //return events.FindEvent(eventId);

        public List<Event> GetAllEvent()
        {
            String sql = "select * from Event";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Event> events = new List<Event>();
            while (reader.Read())
            {
                events.Add(ReadEvent(reader));
            }
            return events;
        }

        private Event ReadEvent(SqlDataReader reader)
        {
            Event e = new Event();

            e.EventId = reader.GetInt32(0);
            e.Navn = reader.GetString(1);
            e.Dato = reader.GetString(2);
            e.TimeStart = reader.GetString(3);
            e.TimeEnd = reader.GetString(4);
            e.MaksDeltagere = reader.GetDouble(5);
            e.EventInfo = reader.GetString(7);

            return e;
        }
        
        public Event EditEvent(int eventId, Event events)
        {
            String sql = "update Event set Navn=@Navn, Dato=@Dato, TimeStart=@TimeStart, TimeEnd=@TimeEnd, MaksDeltagere=@MaksDeltagere, EventInfo=@EventInfo";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@EventId", eventId);
            cmd.Parameters.AddWithValue("@Navn", events.Navn);
            cmd.Parameters.AddWithValue("@Dato", events.Dato);
            cmd.Parameters.AddWithValue("@TimeStart", events.TimeStart);
            cmd.Parameters.AddWithValue("@TimeEnd", events.TimeEnd);
            cmd.Parameters.AddWithValue("@MaksDeltagere", events.MaksDeltagere);
            cmd.Parameters.AddWithValue("@EventInfo", events.EventInfo);

            int row = cmd.ExecuteNonQuery();
            if (row == 1)
            {
                events.EventId = eventId;
                return events;
            }
            else
            {
                return null;
            }
        }

        //events.EditEvent(newValues);

        public Event FindMockEvent(int eventId)
        {
            return events.FindEvent(eventId);
            //Skal normalt være return mockEvents.FindMockEvent(eventId); men programmet deffinere ikke længere mockEvents.
        }

        public List<Event> GetAllEvents()
        {
            return events.GetAllEvents();
        }

        public List<Event> GetAllMockEvents()
        {
            return events.GetAllEvents();
            //Skal normalt være return mockEvents.GetAllMockEvents(); men programmet deffinere ikke længere mockEvents.
        }
    }
}
