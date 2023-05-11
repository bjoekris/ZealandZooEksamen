using DocumentFormat.OpenXml.InkML;
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

        public void DeleteLager(int lagerId)
        {
            lageret.SletLager(lagerId);
        }


        public void CreateLager(Lager la)
        {
            lageret.OpretLager(la);
        }

        public Lager FindLager(int lagerId)
        {
            return lageret.FindLager(lagerId);
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

        public void EditLager(Lager newValuesLager)
        {
            lageret.EditLager(newValuesLager);
        }
    }


}

