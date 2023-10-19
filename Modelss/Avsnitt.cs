using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        public string Titel { get; set; }
        public Avsnitt(string titel)
        {
            Titel = titel;

        }

        public Avsnitt() { }



    }
}
