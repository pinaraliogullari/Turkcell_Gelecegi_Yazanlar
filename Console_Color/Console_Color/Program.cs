using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Color
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();// tüm arka planı renklendirmek için
            Console.ForegroundColor = ConsoleColor.Black;// yazı rengi için
            Console.WriteLine("Merhaba dersler devam ediyor.");
            Console.ReadLine();
        }
    }
}
