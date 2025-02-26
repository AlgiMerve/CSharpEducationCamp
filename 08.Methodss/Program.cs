using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Methodss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            /*
             Geriye değer döndürmeyen metot
            Customer---> Listele,ekle,sil,güncelle
            Void
             */
            //void CustomerList()
            //{
            //    Console.WriteLine("Merve");
            //    Console.WriteLine("Algı");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion
            #region Geriye Değer Döndürmeyen string  parametreli metotlar

            //void WriteMethod(string method)
            //{
            //    Console.WriteLine(method);
            //}
            //WriteMethod("Merve");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri"+ name + " " + surName);
            //}
            //CustomerCard("Merve", "Algı");


            #endregion
            #region Geriye Değer Döndürmeyen int  parametreli metotlar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result=number1+ number2+number3;
            //    Console.WriteLine(result);

            //}
            //Sum(4, 5, 9);

            #endregion
            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Merve Algı";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Merve";
            //    string surname = "Algı"; 

            //        return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion
            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string CountryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke" + CountryName + " - Başkent:" + capital + " - Bayrak Rengi:" + flagColor;
            //    return cardInfo;
            //}
            //Console.Write("Ülke Adını Giriniz:");
            //string x=Console.ReadLine();
            //Console.Write("Başkent Adını Giriniz:");
            //string y = Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz:");
            //string z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z)); 

            #endregion

            Console.ReadKey();

        }
    }
}
