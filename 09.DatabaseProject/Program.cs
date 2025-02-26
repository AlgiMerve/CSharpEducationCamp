using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            // C# programlama dilinde sql yapılarını kullanmamızı sağlayan bir çerçevedir.
            Console.WriteLine("****** C# Veri Tabanlı Ürün - Kategori Bilgi Sitemi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz:");
            Console.WriteLine("-------------------------------------------------------------");

            string tablenumber=Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=MerveALGI\\SQLEXPRESS ;initial Catalog=DbEducationCamp;integrated security=true");
            connection.Open();// bağlantı adrsini açtık
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();// verilerimi geçici belleğe almamı sağlayacak
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows) //burada her satırımı okudum
            {
                foreach (var item in row.ItemArray)
                { 
                    Console.Write(item.ToString());// her satırımı yazdırdım
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
