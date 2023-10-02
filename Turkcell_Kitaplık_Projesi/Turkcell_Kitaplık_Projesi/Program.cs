using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Turkcell_Kitaplık_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamFİyat = 0;
            string secilen;
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi     **  Yabancı Kitaplar Kategorisi      **");
            Console.WriteLine();
            Console.WriteLine("**  1-Çalıkuşu-Reşat Nuri          **  7-Tuna Kılavuzu-Jules Werne      **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban-Yakup Kadri            **  8-Bir Kuzey Macerası-Jack London **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal-HalideEdip    **  9-Altıncı Koğuş-Anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar-Oğuz Atay  **  10-Kumarbaz-Dostoyevski          **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günlerden-H.Yücel   **  11-İki Şehrin Hikayesi-C.Dickens **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf-S. Ali       **  12-Vişne Bahçesi-Anton Çehov     **");
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası: ");
            char secim = char.Parse(Console.ReadLine());
            if (secim == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen Fiyatını öğrenmek istediğiniz kitabın numarasını giriniz: ");
                string numara = Console.ReadLine();
                switch (numara)
                {
                    case "1": Console.WriteLine("Çalıkuşu:12 TL"); break;
                    case "2": Console.WriteLine("Yaban:14 TL"); break;
                    case "3": Console.WriteLine("Sinekli Bakkal:16 TL"); break;
                    case "4": Console.WriteLine("Tehlikeli Oyunlar:18 TL"); break;
                    case "5": Console.WriteLine("Geçtiğim Günlerden:22 TL"); break;
                    case "6": Console.WriteLine("Kuyucaklı Yusuf:24 TL"); break;
                    case "7": Console.WriteLine("Tuna Kılavuzu:12 TL"); break;
                    case "8": Console.WriteLine("Bir Kuzey Macerası:8 TL"); break;
                    case "9": Console.WriteLine("Altıncı Koğuş:17 TL"); break;
                    case "10": Console.WriteLine("Kumarbaz:35 TL"); break;
                    case "11": Console.WriteLine("İki Şehrin Hikayesi:18 TL"); break;
                    case "12": Console.WriteLine("Vişne Bahçesi:14 TL"); break;
                    default: Console.WriteLine("Girdiğiniz değeri kontrol ediniz."); break;



                }
            }
            if (secim == '2')
            {
                Console.WriteLine();
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                Console.Write("Adınız: ");
                string ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                string soyad = Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                string universite = Console.ReadLine();
                Console.WriteLine(ad + " " + soyad + " " + universite);
                string dosya = @"C:\Users\PINAR\Desktop\Geleceği Yazanlar\okur.txt";
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz: " + universite);
                sw.Close();



            }
            if (secim == '3')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugünün Kitabı: Çalıkuşu *****");
                Console.WriteLine();
                Console.WriteLine("************************************");
            }
            if (secim == '4')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\PINAR\Desktop\Geleceği Yazanlar\kitaplar.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string data = sr.ReadLine();
                while (data != null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("************************************");
            }
            if (secim == '5')
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası: ");
                    secilen = Console.ReadLine();
                    if (secilen == "1")
                    {
                        toplamFİyat = toplamFİyat + 12;
                    }
                    else if (secilen == "2")
                    {
                        toplamFİyat = toplamFİyat + 14;
                    }
                    else if (secilen == "3")
                    {
                        toplamFİyat = toplamFİyat + 16;
                    }
                    else if (secilen == "4")
                    {
                        toplamFİyat = toplamFİyat + 18;
                    }
                    else if (secilen == "5")
                    {
                        toplamFİyat = toplamFİyat + 22;
                    }
                    else if (secilen == "6")
                    {
                        toplamFİyat = toplamFİyat + 24;
                    }
                    else if (secilen == "7")
                    {
                        toplamFİyat = toplamFİyat + 12;
                    }
                    else if (secilen == "8")
                    {
                        toplamFİyat = toplamFİyat + 8;
                    }
                    else if (secilen == "9")
                    {
                        toplamFİyat = toplamFİyat + 17;
                    }
                    else if (secilen == "10")
                    {
                        toplamFİyat = toplamFİyat + 35;
                    }
                    else if (secilen == "11")
                    {
                        toplamFİyat = toplamFİyat + 18;
                    }
                    else if (secilen == "12")
                    {
                        toplamFİyat = toplamFİyat + 14;
                    }
                    else

                        Console.WriteLine("Böyle bir kitap numarası yoktur.");
                    Console.WriteLine();
                    Console.Write("Başka bir kitap almak ister misiniz:  ");
                    string cevap = Console.ReadLine();
                    if (cevap == "H" || cevap == "h" || cevap == "hayır" || cevap == "HAYIR")

                        break;




                }

                Console.WriteLine("Toplam Tutar: " + toplamFİyat);
                {
                    Console.WriteLine();
                    Console.WriteLine("İşlem:Yeni Kitap Satın Al");
                }
            }
            if (secim == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd = new Random();
                int sayi = rnd.Next(1, 100);
                Console.Write("Lütfen bir sayı giriniz: ");

                while (sayi != tahmin)
                {
                    
                    tahmin = int.Parse(Console.ReadLine());


                    if (tahmin > sayi)
                    {
                        Console.Write("lütfen daha küçük bir sayı giriniz: ");
                    }
                    else if (tahmin < sayi)
                    {
                        Console.Write("lütfen daha büyük bir sayı giriniz: ");

                    }
                    else if (tahmin == sayi)


                    {
                        Console.WriteLine("tebrikler , bildiniz.");
                        break;
                    }
                }


            }
            Console.ReadLine();

        }
    }
}
