using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

			try
			{
				//işlemler
				Console.Write("lütfen 1. sayıyı giriniz: ");
				int sayi1 = int.Parse(Console.ReadLine());
				Console.Write("Lütfen 2. sayıyı giriniz: ");
				int sayi2 = int.Parse(Console.ReadLine());
				
				int sonuc = sayi1 * sayi2;
                Console.WriteLine(sonuc);

            }
			catch (Exception ex)
			{
				//hata durumunda verilecek mesaj
				Console.WriteLine("lütfen doğru formata değer girişi yapınız");
				Console.WriteLine(ex);			
			}
            
			Console.ReadLine();

		
        }
    }
}
