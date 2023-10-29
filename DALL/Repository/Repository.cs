using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repository
{
    public class Repository : IRepository<Podcast>
    {
        List<Podcast> list = new List<Podcast>();

        Serializer serializer = new Serializer();

        Podcast enPodcast;


        public void Create(Podcast entity)
        {
            list.Add(entity);
            SaveChanges();
        }

        public int GetIndexName(string name)
        {
            int PodcastIndex = GetAll().FindIndex(e => e.Title.Equals(name));
            return PodcastIndex;
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                SaveChanges();
            }

        }

        public List<Podcast> GetAll()
        {
            try
            {
                list = serializer.PoddDeserialize();


            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return list;

        }

        public void SaveChanges()
        {
            serializer.PoddSerialize(list);
            Console.WriteLine(list.Count);
        }

        public void Update(int index, Podcast entity)
        {
            list[index] = entity;
            SaveChanges();
        }

        public Podcast GetPodcast(string url)
        {
            try
            {
                enPodcast = serializer.desiralized(url);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return enPodcast;

        }


    }
}
