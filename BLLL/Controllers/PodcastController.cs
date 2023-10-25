using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAL.Repository;
using Models;

namespace BLL.Controllers
{
    public class PodcastController
    {
        IRepository<Podcast> Repository;

        public PodcastController() {

            Repository = new Repository();
      
        }
        public void Change(int index, Podcast podcast)
        {
            Repository.Update(index, podcast);
        }


        public void CreatePodcast(Podcast podcast)
        {
            Repository.Create(podcast);
        }

        public Podcast GetPodcast(string url)
        {
            Podcast enpodcast;
            enpodcast = Repository.GetPodcast(url);

            return enpodcast;
        }

        public List<Podcast> GetAll() { 
            
            List <Podcast> list= Repository.GetAll();
            return list; 
        }

        public List<Avsnitt> GetAllAvsnitt()
        {

            List<Avsnitt> list = Repository.GetAllAvsnitt();
            return list;
        }


        public void Delete(string name)
        {

            List<Kategori> list = new List<Kategori>();
            //list = Repository.GetAll();

            foreach (Kategori item in list)
            {
                if (item.Genre.Equals(name))
                {

                    int index = GetIndex(name);
                    Repository.Delete(index);

                }
            }
        }


        private int GetIndex(string name)
        {

            return Repository.GetIndexName(name);
        }
    }
}
