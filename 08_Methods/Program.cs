using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Method

            //void CustomerList()
            //{
            //    Console.WriteLine("Customer List:");
            //    Console.WriteLine("John Doe");
            //    Console.WriteLine("Jane Smith");
            //    Console.WriteLine("Alice Johnson");
            //}

            //CustomerList();
            //Console.WriteLine("----------------");
            //CustomerList();
            //Console.WriteLine("----------------");
            //CustomerList();


            //void Sum()
            //{
            //    int x = 43;
            //    int y = 57;
            //    int result = x + y;
            //    Console.WriteLine("The sum of " + x + " and " + y + " is: " + result);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Methodlar

            //void PrintMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //PrintMethod("John Doe");


            //void CustomerCard(string customerName, string customerSurname)
            //{
            //    Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //}

            //CustomerCard("John", "Doe");
            //CustomerCard("Jane", "Smith");
            //CustomerCard("Alice", "Johnson");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Methodlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 +number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(10, 20, 30);

            #endregion

            #region Geriye Değer Döndüren Methodlar

            //string CustomerName()
            //{
            //    return "John Doe";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string studentName = "Alice";
            //    string studentSurname = "Johnson";
            //    return studentName + " " + studentSurname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren Parametreli Methodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + ", Başkent: " + capital + ", Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent adını giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Fransa", "Paris", "Kırmızı - Mavi - Beyaz"));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Methodlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return number1 + number2;
            //}

            //Console.WriteLine(Sum(10, 20));
            //Console.WriteLine(Sum(30, 40));
            //Console.WriteLine(Sum(50, 60));
            //Console.WriteLine(Sum(70, 80));

            #endregion

            #region Örnek Uygulama: Sınav Sonucu Hesaplama  

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti " + "Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi " + "Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 60, 70, 80));
            Console.WriteLine(ExamResult("Ayşe", 40, 50, 60));

            #endregion


            Console.Read();
        }
    }
}
