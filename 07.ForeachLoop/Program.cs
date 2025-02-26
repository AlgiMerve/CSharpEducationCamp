using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            /*
             Foreach(1;2;3;4)
            1:Değişken Türü
            2:Değişken Adı
            3: In
            4: Liste,Koleksiyon,Dizi   
             */

            //string[] name = { "merve", "mert", "hasan" };
            //foreach(string s in name)
            //{
            //    Console.WriteLine(s);
            //}

            //List<int> list = new List<int>()
            //{
            //    1,2,3,4,5,8

            //};
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            // Öğrenci isimleri notlarını saklayack diziler
            string[]studentName=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for(int i=0; i<studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;

                // her öğrenci için 3 sınav notu girişi

                for(int j=0; j< 3; j++)
                {
                    Console.Write($"{studentName[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value= double.Parse(Console.ReadLine());
                    totalExamResult += value;// notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i]= totalExamResult/3;
            }

            //sınav ortalamları
            for(int i=0;i<studentCount;i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}") ;

                if (studentExamAvg[i]>50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi kaldı");
                }

            }



            #endregion





            Console.ReadKey();
        }
    }
}
