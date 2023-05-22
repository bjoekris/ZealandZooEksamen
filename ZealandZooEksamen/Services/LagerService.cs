using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.SqlClient;
using ZealandZooEksamen.MockData;
using ZealandZooEksamen.Model;

namespace ZealandZooEksamen.Services
{
    public class LagerService : ILagerService
    {
        //Connection string. Højreklik på databasen i SQL SOE, vælg properties. Øverste property kopieres ind i "". Password skal selv findes og sættes ind.
        //private const String ConnectionString = @"Data Source=mssql5.unoeuro.com;User ID=bbksolutions_dk;Password=cmfbeAtrkR5zBaF426x3;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        private const String ConnectionString = "Data Source = mssql5.unoeuro.com; Initial Catalog = bbksolutions_dk_db_databasen; User ID = bbksolutions_dk; Password=cmfbeAtrkR5zBaF426x3;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent = ReadWrite; MultiSubnetFailover=False\r\n";
        //SQL koden cmfbeAtrkR5zBaF426x3


        private Lager lageret = new Lager();



        public Lager DeleteLager(int lagerId)
        {
            Lager l = FindLager(lagerId);
            if (l is null)
            {
                return null;
            }

            String sql = "delete from Lager where LagerId = @LagerID";

            SqlConnection conn = new SqlConnection (ConnectionString);
            conn.Open ();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@LagerID", lagerId);

            int row = cmd.ExecuteNonQuery();

            if(row == 1)
            {
                return l;
            }
            else
            {
                return null;
            }


            //Uden SQL
            //lageret.SletLager(lagerId);
        }





        public Lager CreateLager(Lager lager)
        {
            String sql = "insert into Lager values(@LagerNavn,@LagerAntal,@LagerPris,@LagerIndkøbPris)";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@LagerId", lager.LagerId);
            cmd.Parameters.AddWithValue("@LagerNavn", lager.LagerNavn);
            cmd.Parameters.AddWithValue("@LagerAntal", lager.LagerAntal);
            cmd.Parameters.AddWithValue("@LagerPris", lager.LagerPris);
            cmd.Parameters.AddWithValue("@LagerIndkøbPris", lager.LagerIndkøbPris);

            int row = cmd.ExecuteNonQuery();

            if(row == 1)
            {
                return lager;
            }
            else
            {
                return null; 
            }



            //uden SQL
            //lageret.OpretLager(la);
        }


     






        public Lager FindLager(int lagerId)
        {
            String sql = "select * from Lager where LagerId = @LagerId";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@LagerId",lagerId);

            SqlDataReader reader = cmd.ExecuteReader();
            
            if(reader.Read())
            {
                return ReadLager(reader);

            }
            return null;


            //Uden SQL
            //return lageret.FindLager(lagerId);
        }

  





        public List<Lager> GetAllLager()
        {
            String sql = "select * from Lager";

            //Forbindelse 
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            //Kommando
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Sendes til server og få svar ("reader" er svar fra databasen).
            SqlDataReader reader = cmd.ExecuteReader();

            //Laver en liste som svarene kan sættes ind i)
            List<Lager> lager = new List<Lager>();
            while (reader.Read()) 
           {
                lager.Add(ReadLager(reader));
            }
            return lager;

        }

        private Lager ReadLager(SqlDataReader reader)
        {
            Lager l = new Lager();

            l.LagerId = reader.GetInt32(0);
            l.LagerNavn = reader.GetString(1);
            l.LagerAntal = reader.GetFloat(2);
            l.LagerPris = reader.GetFloat(3);
            l.LagerIndkøbPris = reader.GetFloat(4);

            return l;
        }

        public Lager EditLager(int lagerId, Lager lager)
        {
            String sql = "update Lager set LagerNavn=@LagerNavn, LagerAntal=@LagerAntal, LagerPris=@LagerPris, LagerIndkøbPris=@LagerIndkøbPris";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@LagerId", lagerId);
            cmd.Parameters.AddWithValue("@LagerNavn", lager.LagerNavn);
            cmd.Parameters.AddWithValue("@LagerAntal", lager.LagerAntal);
            cmd.Parameters.AddWithValue("@LagerPris", lager.LagerPris);
            cmd.Parameters.AddWithValue("@LagerIndkøbPris", lager.LagerIndkøbPris);

            int row = cmd.ExecuteNonQuery();
            if (row == 1)
            {
                lager.LagerId = lagerId;
                return lager;
            }
            else
            {
                return null;
            }


            //Uden SQL
            //lageret.EditLager(Lager);
        }
    }
}

