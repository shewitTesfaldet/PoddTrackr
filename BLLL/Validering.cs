using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Modelss
{
    public class Validering
    {

        public bool textInputsValidate(string input)
        {
  
            return input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }



        public bool NameInputValidate(string input, List<Kategori> list)
        {
            List<string> kategorinamn = list.Select(k => k.Genre).ToList();
            return !kategorinamn.Contains(input);
        }

        public bool NameInputValidate(string input, List<Podcast> list)
        {
            List<string> podcast = list.Select(p => p.Title).ToList();
            return !podcast.Contains(input);
        }


        public bool NullNotAcceptedValidate(string input, string input1, string input2)
        {
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
            {
                return false;
            }
            return true;

        }

        public bool NullNotAcceptedValidateK(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static void ExceptionFinder(Exception ex)
        {
            string typen = ex.GetType().Name;
            string message = "";
            if (typen.Equals("FileNotFoundException"))
            { message = "Filen kunde inte hittas"; }
            if (typen.Equals("ArgumentOutOfRangeException"))
            { message = "Index låg utanför intervallet. Det får inte vara negativt och måste vara mindre än mängdens storlek"; }
            if (typen.Equals("IndexOutOfRangeException"))
            { message = "Det valda indexet kunde inte hittas"; }
            else { message = "Det har uppstått ett oväntat fel " + ex.Message; }
            MessageBox.Show(message);

        }
        

    }


}
