using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // Değişken Türü [] Dizi Adı=new DeğişkenTÜrü[Eleman Sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            //string[] cities = { "Ankara", "İzmir", "İstanbul", "Manisa" };
            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "sarı", "mavi", "beyaz", "kırmızı" };
            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 55, 11, 39, 27, 9 };
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i] %2== 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //int[] myArray = { 47, 95, 781, 634, 11, 29, 55, 3268, 2, 7, 8, 45 };
            //int maxNumber = myArray[0];
            //for(int i=0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion

            #region Dizi Metotlar

            //string[] customer = { "ali", "buse", "merve", "çınar", "kayra" };
            //int index = Array.IndexOf(customer, "merve");
            //Console.WriteLine(index);

            //int[] number = { 28, 45, 99, 37, 12, 72, 86 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + number.Max() + "Dizinin en küçük elemanı:" + number.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            
            //for(int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]) ;
            //}
            #endregion

            Console.Read();
        }
    }
}
