using Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Net.Http;
using System.Runtime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DAL
{
    internal class Serializer
    {

        public Serializer()
        {

        }
        public void Serialize(List<Kategori> list)
        {
            try
            {
                using (FileStream xmlOut =
                    new FileStream("Kategori.txt", FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(xmlOut))
                    {
                        foreach (Kategori item in list)
                        {
                            if (item.Genre != null)
                            {
                                sw.WriteLine(item.Genre);

                            }

                        }

                    }
                }
            }

            catch (Exception e)

            {
                Console.WriteLine(e.Message);
            }

        }

        public List<Kategori> Deserialize()
        {
            List<Kategori> list = new List<Kategori>();
            try
            {
                using (FileStream xmlIn =
                    new FileStream("Kategori.txt", FileMode.Open, FileAccess.Read))
                {

                    using (StreamReader sr = new StreamReader(xmlIn))
                    {
                        string line = sr.ReadLine();

                        while (line != null)
                        {
                            list.Add(new Kategori(line));
                            line = sr.ReadLine();
                        }

                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return list;
        }

        public Podcast desiralized(string url)
        {
            Podcast podcast = null;
            List<Avsnitt> avsnittsLista = new List<Avsnitt>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string xmlData = response.Content.ReadAsStringAsync().Result;

                        using (StringReader stringReader = new StringReader(xmlData))
                        {
                            XDocument xmlDoc = XDocument.Parse(xmlData);
                            string poddTitel = "";
                            int antalAvsnitt = 0;
                            string title = "";
                            string beskrivning = "";

                            foreach (XElement item in xmlDoc.Descendants("image"))
                            {

                                poddTitel = item.Element("title")?.Value;

                            }
                           
                            foreach (XElement item in xmlDoc.Descendants("item"))
                            {
                                title = item.Element("title")?.Value;
                                string beskrivningen = item.Element("description")?.Value;


                                if (!string.IsNullOrEmpty(title))
                                {
                                    Avsnitt avsnitt = new Avsnitt(title, beskrivningen);
                                                                        avsnittsLista.Add(avsnitt);

                                    
                                }

                            }
                            Kategori kategori = new Kategori("");

                            podcast = new Podcast("", poddTitel, kategori, avsnittsLista);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Något gick fel vid hämtning av data från URL:en.");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fel: " + e.Message);
            }

            return podcast;
        }

        public void PoddSerialize(List<Podcast> list)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(list.GetType());
                using (FileStream fs = new FileStream("Podcast.xml", FileMode.Create))
                {
                    xml.Serialize(fs, list);

                }

            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public List<Podcast> PoddDeserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream fileStream = new FileStream("Podcast.xml", FileMode.Open, FileAccess.Read))
                {
                    var list = (List<Podcast>)xmlSerializer.Deserialize(fileStream);
                    return list;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Podcast>();
            }
        }

    }
}




