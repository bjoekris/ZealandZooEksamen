using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public class NyhedsbrevService : INyhedsbrevService
    {
        private const String ConnectionString = "Data Source = mssql5.unoeuro.com; Initial Catalog = bbksolutions_dk_db_databasen; User ID = bbksolutions_dk; Password=cmfbeAtrkR5zBaF426x3;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent = ReadWrite; MultiSubnetFailover=False\r\n";

        private Nyhedsbrev nyhedsbrev = new Nyhedsbrev();



        public Nyhedsbrev CreateNyhedsbrev(Nyhedsbrev nyhedsbrev)
        {
            String sql = "insert into Nyhedsbrev values(@Navn,@Telefon)";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@NyhedsbrevId", nyhedsbrev.NyhedsbrevId);
            cmd.Parameters.AddWithValue("@Navn", nyhedsbrev.Navn);
            cmd.Parameters.AddWithValue("@Telefon", nyhedsbrev.Telefon);


            int row = cmd.ExecuteNonQuery();

            if (row == 1)
            {
                return nyhedsbrev;
            }
            else
            {
                return null;
            }
        }

        public List<Nyhedsbrev> GetAllNyhedsbrev()
        {
            String sql = "select * from Nyhedsbrev";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Nyhedsbrev> nyhedsbrev = new List<Nyhedsbrev>();
            while (reader.Read())
            {
                nyhedsbrev.Add(ReadNyhedsbrev(reader));
            }
            return nyhedsbrev;

        }



        private Nyhedsbrev ReadNyhedsbrev(SqlDataReader reader)
        {
            Nyhedsbrev n = new Nyhedsbrev();

            n.NyhedsbrevId = reader.GetInt32(0);
            n.Navn = reader.GetString(1);
            n.Telefon = reader.GetString(2);

            return n;

        }




        //        public List<Nyhedsbrev> GetAllNyhedsbrev()
        //        {
        //            String sql = "select * from Nyhedsbrev";

        //            //connection
        //            SqlConnection conn = new SqlConnection(ConnectionString);
        //            conn.Open();

        //            //kommando
        //            SqlCommand cmd = new SqlCommand(sql, conn);

        //            //Sendes til server og få svar ("reader" er svar fra databasen).
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            //Laver en liste som svarene sættes ind i)
        //            while (reader.Read())
        //            {
        //                new List<Nyhedsbrev>().Add(ReadNyhedsbrev(reader));
        //            }
        //            return new List<Nyhedsbrev>();
        //        }
    }
}
