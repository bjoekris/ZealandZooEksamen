﻿using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.DataAnnotations;

namespace ZealandZooEksamen.Model
{
    public class Tilmeldte
    {
        public int TilmeldingId { get; set; }
        public string Navn { get; set; }

        [MaxLength(8)]
        public string Telefon { get; set; }


        public Tilmeldte() { }


        public Tilmeldte(int tilmeldingId, string navn, string telefon) 
        {
            TilmeldingId = tilmeldingId;
            Navn = navn;
            Telefon = telefon;
        }

        public string GetInfo()
        { 
            return ToString();
        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Telefon)}={Telefon.ToString()}}}";
        }

        private readonly List<Tilmeldte> tilmeldt = new List<Tilmeldte>();


        public List<Tilmeldte> GetAllTilmeldte()
        {
            return new List<Tilmeldte>(tilmeldt);
        }


        public Tilmeldte FindTilmeldte(int tilmeldingId)
        {
            foreach (Tilmeldte t in tilmeldt)
            {
                if (t.TilmeldingId == tilmeldingId)
                {
                    return t;
                }
            }
            throw new KeyNotFoundException();
        }

        public void OpretTilmeldte(Tilmeldte t)
        {
            tilmeldt.Add(t);
        }

        public void SletTilmeldte(int tilmeldingId)
        {
            Tilmeldte sletTilmelding = FindTilmeldte(tilmeldingId);
            tilmeldt.Remove(sletTilmelding);
        }
    }
}
