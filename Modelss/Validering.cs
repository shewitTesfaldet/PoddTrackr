using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Modelss
{
    public class Validering
    {

        public bool textInputsValidate(string input)
        {
            // Kontrollera om inmatningen endast innehåller bokstäver

            return input.All(c => char.IsLetter(c));

        }


        public bool NameInputValidate<T>(string input, List<Kategori> list)
        {
            List<string> kategorinamn = list.Select(k => k.Genre).ToList();
            return !kategorinamn.Contains(input);
        }


        public bool NameInputValidate<T>(string input, List<Podcast> list)
        {
            List<string> podcast = list.Select(k => k.Namn).ToList();
            return !podcast.Contains(input);
        }

        //public bool NameInputValidate<T>(string input, List<Podcast> list)
        //{
        //    return !list.Any(podcast => string.Equals(podcast.GetFullStringRepresentation(), input, StringComparison.OrdinalIgnoreCase));
        //}




        public bool NullNotAcceptedValidate(string input, string input1, string input2)
        {
            if (string.IsNullOrEmpty(input))

            {
                return false;
            }
            else if(string.IsNullOrEmpty(input1))
            {return false;
            }
            else if (string.IsNullOrEmpty(input2))
            {
                return false;
            }
            else
            {
                // Do something with the input
                return true;
            }
        }

        public bool NullNotAcceptedValidateK(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                // Do something with the input
                return true;
            }
        }

    }


}
