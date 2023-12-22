using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka14
{
    class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }
        protected string Name;
        public string name
        {
            get { return this.Name; }
        }
            virtual public void CalculatePay()
        {
            Console.WriteLine("Вызвано для {0}", name);
        }
        
    }


}
