using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL.Repository

{
    public class KategoriRepository: IRepository<Kategori>
    { 
        Serializer serializer; 
        List<Kategori> listOfKategori; 

        public KategoriRepository() {
            serializer = new Serializer();
            listOfKategori = new List<Kategori>();
            listOfKategori = GetAll();
           
        }
        public void Create(Kategori entity)
        {
          listOfKategori.Add(entity);
          SaveChanges();
            
        }

        public void Update(int index, Kategori entity)
        {
            listOfKategori[index] = entity;
            SaveChanges();
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < listOfKategori.Count)
            {
                listOfKategori.RemoveAt(index);
                SaveChanges();

            }
        }

        public int GetIndexName(string name) {
            int KategoriIndex = GetAll().FindIndex(e => e.Genre.Equals(name));
            return KategoriIndex;   
        }
        public List<Kategori> GetAll()
        {    
            try
            {
                listOfKategori= serializer.Deserialize();

            }

            catch (Exception e) { 
             Console.WriteLine(e.Message);
               
            }                     
            return listOfKategori;
          
        }

        public void SaveChanges()
        {
            serializer.Serialize(listOfKategori); 
        }

       

      

        public Podcast GetPodcast(string url)
        {
            throw new NotImplementedException();
        }

        public List<Avsnitt> GetAllAvsnitt()
        {
            throw new NotImplementedException();
        }
    }
}
