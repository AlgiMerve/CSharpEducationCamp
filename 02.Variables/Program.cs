using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            ////double number;
            //number=4.75;
            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, PotatoPrice, tomataPrice;

            //applePrice = 14.85;
            //orangePrice = 29.95;
            //strawberryPrice = 45;
            //PotatoPrice = 9.74;
            //tomataPrice = 20.55;


            //Console.WriteLine("----- Elma Birim Fiyatı:" + applePrice +" TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı:" + PotatoPrice + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı:" + tomataPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, PotatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //PotatoGram = 4.853;
            //tomatoGram = 3.745;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double appleTotalPrice = appleGram * applePrice;
            //double stawberryTotalPrice = strawberryGram * strawberryPrice;
            //double PotatoTotalPrice = PotatoGram * PotatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomataPrice;

            //Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fiyatı: " + applePrice + "- Gramaj:" + appleGram + " - Toplam Tutar:"+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fiyatı: " + orangePrice + "- Gramaj:" + orangeGram + " - Toplam Tutar:"+ orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek -" + "Birim Fiyatı: " + strawberryPrice + "- Gramaj:" + strawberryGram + " - Toplam Tutar:" + stawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates -" + "Birim Fiyatı: " + PotatoPrice + "- Gramaj:" + PotatoGram + " - Toplam Tutar:" + PotatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates -" + "Birim Fiyatı: " + tomataPrice + "- Gramaj:" + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + stawberryTotalPrice + PotatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice+" TL");
            #endregion
            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion
            #region Klavyeden Veri Girişleri
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi :");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi :");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Yolcu: " +passengerIdentityNumber+"numaralı"+ passengerName + " " + passengerSurname + " " + passengerAge + " " + passengerDistrict + "/" + passengerCity);
            #endregion
            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesCount + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3,result;
            //Console.Write("Lütfen 1.sınav notunu giriniz:");
            //exam1= double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+ result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+ gender);
            #endregion


            Console.Read();
        }
    }
}
