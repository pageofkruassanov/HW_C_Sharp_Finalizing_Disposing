using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_Finalizing_Disposing
{
    internal class Play : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
        }
        ~Play() 
        { 
            Console.WriteLine($"Play {Title} destroyed"); 
        }
        public void Dispose() 
        {
            Console.WriteLine($"Play {Title} destroyed"); }
    }
}
