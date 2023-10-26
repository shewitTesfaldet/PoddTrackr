using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kategori
    { 
        public string Genre { get; set; }

        public Kategori(string genre)
        {
            Genre = genre;
        }
        public Kategori() { }
    }
}
