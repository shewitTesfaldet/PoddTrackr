//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace DAL.Repository
//{
//    public class Repository<T> : IRepository<T>
//    {
//        public void Create(T entity)
//        {


//            try
//            {
//                using (FileStream fileStream = new FileStream("Kategori.txt", FileMode.Append, FileAccess.Write))
//                {
//                    using (StreamWriter writer = new StreamWriter(fileStream))
//                    {
//                        writer.WriteLine(kategori.Genre);
//                    }

//                }

//            }

//            catch (IOException y)
//            {
//                Console.WriteLine(y.Message);
//            }
//            throw new NotImplementedException();
//        }

//        public void Delete(int index)
//        {
//            throw new NotImplementedException();
//        }

//        public List<T> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public void SaveChanges()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(int index, T entity)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
