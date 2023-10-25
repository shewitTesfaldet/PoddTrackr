using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
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
                            foreach (XElement item in xmlDoc.Descendants("channel")) {
                               string beskrivningen = item.Element("description")?.Value;
                                beskrivning = beskrivningen.Replace(",", "");
                            }
                            Console.WriteLine(beskrivning);
                            foreach (XElement item in xmlDoc.Descendants("item"))
                            {
                                title = item.Element("title")?.Value;


                                if (!string.IsNullOrEmpty(title))
                                {
                                    Avsnitt avsnitt = new Avsnitt(title);
                                    avsnittsLista.Add(avsnitt);
                                    antalAvsnitt++;
                                }

                            }
                            Kategori kategori = new Kategori("");

                            podcast = new Podcast(antalAvsnitt, "", poddTitel, kategori, beskrivning);
                            Console.WriteLine(poddTitel);
                            podcast.avsnittLista = avsnittsLista;
                            AvsnittSerialize(avsnittsLista);



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
                using (FileStream xmlOut =
                    new FileStream("Podcast.txt", FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(xmlOut))
                    {
                        foreach (Podcast item in list)
                        {
                            if (item.Title != null && item.Namn != null && item.Kategori.Genre != null && item.AntalAvsnitt != 0)
                            {
                                sw.WriteLine(item.AntalAvsnitt + ", " + item.Namn + ", " + item.Title + ", " + item.Kategori.Genre + ", " + item.Beskrivning);
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

        public List<Podcast> PoddDeserialize()
        {
            List<Podcast> list = new List<Podcast>();
            try
            {
                using (FileStream xmlIn =
                    new FileStream("Podcast.txt", FileMode.Open, FileAccess.Read))
                {

                    using (StreamReader sr = new StreamReader(xmlIn))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Podcast pod = new Podcast();
                            string[] arg = line.Split(',');

                            if (arg.Length == 5) {

                                string antal = arg[0];
                                pod.AntalAvsnitt = int.Parse(antal);
                                pod.Namn = arg[1];
                                pod.Title = arg[2];
                                Kategori nyKategori = new Kategori(arg[3]);
                                pod.Kategori = nyKategori;
                                pod.Beskrivning = arg[4];
                            }

                            foreach (string arg2 in arg)
                            {
                                Console.WriteLine(arg2);
                            }

                            list.Add(pod);
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



        public List<Avsnitt> AvsnittSerialize(List<Avsnitt> list)
        {
            try
            {
                using (FileStream xmlOut =
                    new FileStream("Avsnitt.txt", FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(xmlOut))
                    {
                       foreach(Avsnitt avsnitt in list) {
                            sw.WriteLine(avsnitt.Titel);

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

    }
}



