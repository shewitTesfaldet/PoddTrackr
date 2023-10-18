using Models;
using System;
using System.Collections.Generic;
using System.IO;
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
                    new FileStream("Kategori.txt", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(xmlOut))
                    {
                        foreach (Kategori item in list)
                        {
                            if (item.Genre != null)
                            {
                                sw.WriteLine(item.Genre);

                            }
                            else {
                               
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
    }
}