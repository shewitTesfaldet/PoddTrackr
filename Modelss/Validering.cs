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


        public bool NameInputValidate(string input, List<Kategori> list)
        {
            List<string> kategorinamn = list.Select(k => k.Genre).ToList();
            return !kategorinamn.Contains(input);
        }

        //fungerar inte när man skriver in samma podcast flera gånger
        public bool NameInputValidate(string input, List<Podcast> list)
        {
            List<string> podcast = list.Select(p => p.Namn).ToList();
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

    }


}
