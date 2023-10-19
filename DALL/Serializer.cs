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

                            foreach (XElement item in xmlDoc.Descendants("item"))
                            {
                                title = item.Element("title")?.Value;
                                beskrivning = item.Element("description")?.Value;


                                if (!string.IsNullOrEmpty(title))
                                {
                                    Avsnitt avsnitt = new Avsnitt(title);
                                    avsnittsLista.Add(avsnitt);
                                    antalAvsnitt++;
                                }

                            }
                            Kategori kategori = new Kategori("");

                            podcast = new Podcast(poddTitel, kategori, beskrivning, antalAvsnitt, 0, "");
                            Console.WriteLine(poddTitel);
                            podcast.avsnittLista = avsnittsLista;


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
                                sw.WriteLine(item.AntalAvsnitt + " " + item.Namn + " " + item.Title + " " + item.Frekvens + " " + item.Kategori.Genre);

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
                            string[] arg = line.Split(' ');
                            foreach (string arg2 in arg)
                            {
                                Console.WriteLine(arg2);
                                // Här kan du använda 'arg2' för att sätta egenskaper på ditt 'pod'-objekt
                            }
                            list.Add(pod);
                        }


                        //foreach (Podcast item in list)
                        //{
                        //    string line = sr.ReadLine();


                        //   Podcast pod = new Podcast();
                        //   string[] arg = line.Split(' ');
                        // foreach(string arg2 in arg)
                        //    {

                        //        Console.WriteLine(arg2); 


                        //    }


                        //    while (line != null)



                        //    {
                        //        //list.Add(line);
                        //        line = sr.ReadLine();
                        //    }

           



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



