using System.Data.SqlClient;
using ZealandZooEksamen.Model;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Spreadsheet;
using ZealandZooEksamen.MockData;




namespace ZealandZooEksamen.Services
{
    public class SalgService : ISalgService
    {
        //Connection string. Højreklik på databasen i SQL SOE, vælg properties. Øverste property kopieres ind i "". Password skal selv findes og sættes ind.
        //private const String ConnectionString = @"Data Source=mssql5.unoeuro.com;User ID=bbksolutions_dk;Password=cmfbeAtrkR5zBaF426x3;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        private const String ConnectionString = "Data Source = mssql5.unoeuro.com; Initial Catalog = bbksolutions_dk_db_databasen; User ID = bbksolutions_dk; Password=cmfbeAtrkR5zBaF426x3;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent = ReadWrite; MultiSubnetFailover=False\r\n";
        //SQL koden cmfbeAtrkR5zBaF426x3


        private Salg lageret = new Salg();



        public Salg DeleteSalg(int salgsId)
        {
            Salg s = FindSalg(salgsId);
            if (s is null)
            {
                return null;
            }

            String sql = "delete from Salg where SalgsId = @SalgsID";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SalgsID", salgsId);

            int row = cmd.ExecuteNonQuery();

            if (row == 1)
            {
                return s;
            }
            else
            {
                return null;
            }


           
        }





        public Salg CreateSalg(Salg salg)
        {
            String sql = "insert into Salg values(@SalgsNavn,@SalgsAntal,@SalgsPris)";
           

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            
            cmd.Parameters.AddWithValue("@SalgsNavn", salg.SalgsNavn);
            cmd.Parameters.AddWithValue("@SalgsAntal", salg.SalgsAntal);
            cmd.Parameters.AddWithValue("@SalgsPris", salg.SalgsPris);

            int row = cmd.ExecuteNonQuery();

            if (row == 1)
            {
                try { 
                    OpdaterLager(salg);
                    return salg;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        
        private void OpdaterLager(Salg salg)
        {
            String sql = "update Lager set LagerAntal=LagerAntal - @SalgsAntal where LagerNavn=@SalgsNavn";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@SalgsNavn", salg.SalgsNavn);
            cmd.Parameters.AddWithValue("@SalgsAntal", salg.SalgsAntal);

            int row = cmd.ExecuteNonQuery();
            if (row != 1)
            {
                throw new Exception();
            }

        }








        public Salg FindSalg(int salgsId)
        {
            String sql = "select * from Salg where SalgsId = @SalgsId";
           

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@SalgsId", salgsId);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return ReadSalg(reader);

            }
            return null;


            
        }







        public List<Salg> GetAllSalg()
        {
            String sql = "select * from Salg";

            //Forbindelse 
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //Kommando
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Sendes til server og få svar ("reader" er svar fra databasen).
            SqlDataReader reader = cmd.ExecuteReader();

            //Laver en liste som svarene kan sættes ind i)
            List<Salg> salg = new List<Salg>();
            while (reader.Read())
            {
                salg.Add(ReadSalg(reader));
            }
            return salg;

        }

        private Salg ReadSalg(SqlDataReader reader)
        {
            Salg s = new Salg();

            s.SalgsId = reader.GetInt32(0);
            s.SalgsNavn = reader.GetString(1);
            s.SalgsAntal = reader.GetFloat(2);
            s.SalgsPris = reader.GetFloat(3);

            return s;
        }

        public Salg EditSalg(int salgsId, Salg salg)
        {
            String sql = "update Salg set SalgsNavn=@SalgsNavn, SalgsAntal=@SalgsAntal, SalgsPris=@SalgsPris where SalgsId=@SalgsId";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@SalgsId", salgsId);
            cmd.Parameters.AddWithValue("@SalgsNavn", salg.SalgsNavn);
            cmd.Parameters.AddWithValue("@SalgsAntal", salg.SalgsAntal);
            cmd.Parameters.AddWithValue("@SalgsPris", salg.SalgsPris);

            int row = cmd.ExecuteNonQuery();
            if (row == 1)
            {
                salg.SalgsId = salgsId;
                return salg;
            }
            else
            {
                return null;
            }


        }
    }
}

