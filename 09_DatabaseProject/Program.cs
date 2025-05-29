using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net is a set of classes that expose data access services for .NET Framework programmers.

            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");



            SqlConnection connection = new SqlConnection("Data Source=LEJON\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory" , connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow item in dataTable.Rows)
            {
                Console.WriteLine(item[0] + " - " + item[1]);
            }

























            Console.Read();
        }
    }
}
