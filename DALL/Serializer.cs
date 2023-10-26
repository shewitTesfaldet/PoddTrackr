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
                            foreach (XElement item in xmlDoc.Descendants("channel"))
                            {
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

                            podcast = new Podcast(antalAvsnitt, "", poddTitel, kategori, beskrivning, avsnittsLista);
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
                using (FileStream fs = new FileStream("Podcast.xml", FileMode.Create, FileAccess.Write))
                {
                    xml.Serialize(fs, list);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        //public void PoddSerialize(List<Podcast> list)
        //{
        //    try 

        //    {
                
        //        string filePath = "Podcast.xml";

        //        using (FileStream xmlOut = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        //        {

        //            XmlWriterSettings settings = new XmlWriterSettings
        //            {
        //                Indent = true,
        //              IndentChars = "  ",
        //              NewLineChars = "\n"   ,
        //              NewLineHandling = NewLineHandling.Replace

        //            };
                 
        //            using (XmlWriter writer = XmlWriter.Create(xmlOut, settings))
        //            {

        //                //if (writer.WriteStartDocument != null)

        //                    writer.WriteStartDocument();
        //                   writer.WriteStartElement("Podcast");
        //                foreach (Podcast podd in list)
        //                    {

        //                    writer.WriteElementString("AntalAvsnitt", podd.AntalAvsnitt.ToString());
        //                        writer.WriteElementString("Title", podd.Title);
        //                        writer.WriteElementString("Kategori", podd.Kategori.Genre);
        //                        writer.WriteElementString("Beskrivning", podd.Beskrivning);
        //                        writer.WriteElementString("Namn", podd.Namn);

        //                        writer.WriteStartElement("AvsnittsLista");
        //                        foreach (Avsnitt avsnitt in podd.AvsnittsLista)
        //                        {
        //                            writer.WriteElementString("AvsnittTitle", avsnitt.Titel);
        //                        }
        //                        writer.WriteEndElement(); // AvsnittsLista

        //                        // Avsluta Podcast-elementet.
        //                        writer.WriteEndElement();
        //                    // Avsluta rotelementet.

        //                    // Avsluta dokumentet.
        //                    writer.WriteEndDocument();
        //                }
                         

        //            }


        //            }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //}



        public List<Podcast> PoddDeserialize()
        {
            List<Podcast> podcastList = new List<Podcast>();

            try
            {
                using (FileStream xmlIn = new FileStream("Podcast.xml", FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Podcast));
                    Podcast podd;

                    while (true)
                    {
                        try
                        {
                            podd = (Podcast)serializer.Deserialize(xmlIn);
                            Console.WriteLine(podd.Beskrivning);
                            podcastList.Add(podd);
                            foreach (Podcast podden in podcastList)
                            {
                                foreach (Avsnitt avsnitt in podden.AvsnittsLista)
                                {
                                    Console.WriteLine("test" + avsnitt.Titel);
                                }
                            }
                        }
                        catch (InvalidOperationException)
                        {
                            // När inget mer kan deserialiseras kommer Deserialize att kasta InvalidOperationException.
                            // När detta händer, bryter vi ut ur loopen.
                            break;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return podcastList;
        }

    }
}




