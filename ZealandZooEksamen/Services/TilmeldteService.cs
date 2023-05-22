using System.Data.SqlClient;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public class TilmeldteService : ITilmeldteService
    {
        private const String ConnectionString = "Data Source = mssql5.unoeuro.com; Initial Catalog = bbksolutions_dk_db_databasen; User ID = bbksolutions_dk; Password=cmfbeAtrkR5zBaF426x3;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent = ReadWrite; MultiSubnetFailover=False\r\n";

        private Tilmeldte tilmeldt = new Tilmeldte();


        //opret tilmelding
        public Tilmeldte CreateTilmeldte(Tilmeldte tilmeldte)
        {
            String sql = "insert into TilmeldteEvent values(@Navn,@Telefon)";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@LagerId", lager.LagerId);
            cmd.Parameters.AddWithValue("@Navn", tilmeldte.Navn);
            cmd.Parameters.AddWithValue("@Telefon", tilmeldte.Telefon);

            int row = cmd.ExecuteNonQuery();

            if (row == 1)
            {
                return tilmeldte;
            }
            else
            {
                return null;
            }

        }


        //Tilmeldingsliste
        public List<Tilmeldte> GetAllTilmeldte()
        {
            String sql = "select * from TilmeldteEvent";

            //connection
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //kommando
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Sendes til server og få svar ("reader" er svar fra databasen).
            SqlDataReader reader = cmd.ExecuteReader();

            //Laver en liste som svarene sættes ind i)
            List<Tilmeldte> tilmeldte = new List<Tilmeldte>();
            while (reader.Read())
            {
                tilmeldte.Add(ReadTilmeldte(reader));
            }
            return tilmeldte;

        }


        //Find Tilmelding
        public Tilmeldte FindTilmeldte(int TilmeldingId)
        {
            String sql = "select * from TilmeldteEvent where Id = @Id";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", TilmeldingId);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return ReadTilmeldte(reader);

            }
            return null;

        }


        //Reader
        private Tilmeldte ReadTilmeldte(SqlDataReader reader)
        {
            Tilmeldte t = new Tilmeldte();

            t.TilmeldingId = reader.GetInt32(0);
            t.Navn = reader.GetString(1);
            t.Telefon = reader.GetInt32(2);

            return t;
        }

    }

}
