using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_Finalizing_Disposing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Play play = new Play("Exiles", "James Joyce", "Drama", 2013);
            play.DisplayInfo();
            play.Dispose();

            Console.WriteLine();

            using (Store store = new Store("About you"))
            {
                store.DisplayInfo();
            }

            Console.ReadLine();
        }
    }
}
