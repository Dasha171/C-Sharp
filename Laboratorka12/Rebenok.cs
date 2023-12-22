using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka12
{
    internal class Rebenok
    {
        private string[] haract = new string[5];
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < haract.Length)
                    return haract[index];
                else
                    return "Недопустимый индекс";
            }
            set
            {
                if (index >= 0 && index < haract.Length)
                    haract[index] = value;
            }
        }
    }
}
