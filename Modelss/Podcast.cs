using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;

namespace Models
{
    public class Podcast
    {
        public int AntalAvsnitt { get; set; }

        public string Title { get; set; }
        public Kategori Kategori { get; set; }
        public string Beskrivning { get; set; }
        public string Namn { get; set; }
        public List<Avsnitt> avsnittLista;
        
        public Podcast(int antalAvsnitt, string namn, string title, Kategori kategori, string beskrivning ) {
            Title = title;
            Kategori = kategori;
            Beskrivning = beskrivning;
            AntalAvsnitt = antalAvsnitt;
            Namn = namn;
            List<Avsnitt> avsnittLista = new List<Avsnitt>();

        }

        public Podcast() { }

    }
}