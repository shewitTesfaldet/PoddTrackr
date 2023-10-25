using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void Update(int index,T entity);
        void Delete(int index);

        List<T> GetAll();

      
        void SaveChanges();

        Podcast GetPodcast(string url);
        int GetIndexName(string name);
        List<Avsnitt> GetAllAvsnitt();
    }
}
