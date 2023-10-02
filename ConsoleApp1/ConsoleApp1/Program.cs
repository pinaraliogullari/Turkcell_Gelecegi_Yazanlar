using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //DateTime currentdate=Convert.ToDateTime( DateTime.Now.ToShortDateString());
            

           // DateTime birthdate = Convert.ToDateTime("08.02.1994");
           // TimeSpan zaman = (currentdate - birthdate);
           // int fark = zaman.Days;
           // Console.WriteLine(fark);
           // Console.ReadLine();


            //metin belgesi oluşturma içine yazma ve kaydetme
            StreamWriter sw = new StreamWriter("C:\\Users\\PINAR\\Desktop\\deneme.txt");
            //sw.Write("Merhaba . Bu bir deneme metin belgesidir.");
            //sw.Close();

            //klasvyeden girilen metni dosyaya yazdırma
            //Console.Write("Lğtfen bir metin giriniz: ");
            //string metin = Console.ReadLine();
            //sw.Write(metin);
            //sw.Close();
            //Console.ReadLine();

            //var olan bir metin dosyasını okuma.

            FileStream fs = new FileStream(@"C:\\Users\\PINAR\\Desktop\\Geleceği Yazanlar\\deneme2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string metin = sr.ReadLine();

            while (metin != null) 
            {
                Console.WriteLine(metin);
                metin = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            Console.ReadLine();
        }

    }
}
