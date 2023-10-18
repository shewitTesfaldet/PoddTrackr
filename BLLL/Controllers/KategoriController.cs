using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using System.Xml.Serialization; 

using Models;


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

        public void Delete(int index) 
        {
            Repository.Delete(index);
        }

    }

}
