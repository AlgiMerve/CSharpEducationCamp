using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //int exam1, exam2,exam3,average;
            //string result=" ";
            //Console.Write("1.sınav notu:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("2.sınav notu:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3.sınav notu:");
            //exam3 = int.Parse(Console.ReadLine());

            //average=(exam1+exam2+exam3)/3;
            //Console.Write("Sınavların ortalaması:" + average);

            //if(average>0 & average<=50)
            //{
            //    result = "sonuç vasat";

            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";

            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç İyi";

            //}
            //if (average > 84)
            //{
            //    result = "sonuç Çok İyi";

            //}
            //Console.WriteLine(result);
            #endregion
            #region Mod İşlemleri

            //Console.Write("Lütfen 1.sayıyı giriniz:");
            //int number1=int .Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz:");
            //int number2=int .Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            #endregion
            #region Char Değişkenler ile Karar 

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team =='g' | team =='G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion
            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detaylı görmek istediğiniz menü seçiniz");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Karışık Pizza");
            //    Console.WriteLine("2-Akdeniz Pizza");
            //    Console.WriteLine("3- Margarita Pizza") ;
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Baklava");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //}


            #endregion
            #region Switch case

            //Console.Write("Lütfen Ay Girişini Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}


            #endregion

            Console.ReadKey();

        }
    }
}
