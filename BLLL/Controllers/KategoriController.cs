using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using System.Xml.Serialization; 

using Models;
using System.Dynamic;

namespace BLL.Controllers
{
    public class KategoriController 
    {
        IRepository<Kategori> Repository;
        public KategoriController() {
            Repository = new KategoriRepository(); 
                 
        }

       public void CreateKategori(string kategoriNamn)
        {   
            Kategori kategori= new Kategori(kategoriNamn);  
            Repository.Create(kategori);           
        }

        public List<Kategori> GetAll()
        {
            List<Kategori> list = new List<Kategori>();
            list = Repository.GetAll();
            return list;
        }

        public void Change(int index, Kategori kategori)
        {  
            Repository.Update(index, kategori); 
        }


        public void Delete(string name)
        {

            List<Kategori> list = new List<Kategori>();
            list = Repository.GetAll();

            foreach (Kategori item in list) {
                if (item.Genre.Equals(name)) {

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
