using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;

namespace Models
{
    public class Podcast
    {
        public string Title { get; set; }
        public Kategori Kategori { get; set; }
        public int Frekvens { get; set; }   
        public string Beskrivning { get; set; }
        public int AntalAvsnitt { get; set; }

        public string Namn { get; set; }
        public List<Avsnitt> avsnittLista;
        
        public Podcast(string title, Kategori kategori, string beskrivning, int antalAvsnitt, int frekvens, string namn) {
            Title = title;
            Kategori = kategori;
            Frekvens = frekvens;
            Beskrivning = beskrivning;
            AntalAvsnitt = antalAvsnitt;
            Namn = namn;
            List<Avsnitt> avsnittLista = new List<Avsnitt>();

        }

        public Podcast() { }

    }
}