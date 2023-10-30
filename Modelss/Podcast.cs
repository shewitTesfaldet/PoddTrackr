using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;

namespace Models
{
    [Serializable]
    public class Podcast
    {

        public string Title { get; set; }
        public Kategori Kategori { get; set; }
        public string Namn { get; set; }

        //[XmlArray("AvsnittsLista")]
        //[XmlArrayItem("AvsnittTitle")]
        public List<Avsnitt> AvsnittsLista;


        public Podcast(string namn, string title, Kategori kategori, List<Avsnitt> avsnittsLista) {
            Title = title;
            Kategori = kategori;
            Namn = namn;
            AvsnittsLista = avsnittsLista;

        }

        public Podcast() { }

    }
}