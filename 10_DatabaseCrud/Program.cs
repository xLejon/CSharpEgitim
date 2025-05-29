using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud işlemleri, veritabanındaki verileri ekleme, güncelleme ve silme işlemlerini içerir.
            //Crud - Create, Read, Update, Delete işlemlerini ifade eder.

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LEJON\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); // ExecuteNonQuery, değişikleri kaydeder ve veritabanına veri ekler.
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Eklemek İstediğiniz Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LEJON\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true); // Ürün durumu varsayılan olarak true olarak ayarlanıyor.
            //command.ExecuteNonQuery();
            //connection.Close(); 
            //Console.WriteLine("Ürün başarıyla eklendi.");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=LEJON\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silmek istediğiniz ürünün ID'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=LEJON\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery(); // ExecuteNonQuery, değişiklikleri kaydeder ve veritabanından veri siler.

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla silindi.");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellemek istediğiniz ürünün ID'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=LEJON\\SQLEXPRESS;Initial Catalog=EgitimKampiDB;Integrated Security=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery(); // ExecuteNonQuery, değişiklikleri kaydeder ve veritabanında güncelleme yapar.
            //connection.Close();

            //Console.WriteLine("Ürün başarıyla güncellendi.");

            #endregion

            Console.Read();
        }
    }
}
