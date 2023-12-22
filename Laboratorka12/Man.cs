using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka12
{
    internal class Man
    {
       

        private string[] chert = new string[5];
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chert.Length)
                    return chert[index];
                else
                    return "Недопустимый индекс";
            }
            set
            {
                if (index >= 0 && index < chert.Length)
                    chert[index] = value;
            }
        }
    }
}

