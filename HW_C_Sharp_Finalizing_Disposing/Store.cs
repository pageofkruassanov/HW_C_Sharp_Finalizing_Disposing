using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_Finalizing_Disposing
{
    internal class Store : IDisposable
    {
        public string Name { get; set; }

        public Store(string name)
        {
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }

        ~Store() 
        { 
            Console.WriteLine($"Store {Name} destroyed"); 
        }
        public void Dispose() 
        { 
            Console.WriteLine($"Store {Name} destroyed"); 
        }
    }
}
