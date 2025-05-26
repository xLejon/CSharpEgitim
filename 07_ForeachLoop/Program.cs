using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {

            #region Foreach Döngüsü
            //Foreach döngüsü, dizilerdeki tüm elemanları tek tek dolaşmak için kullanılır.
            //1: Değişken türü (string, int, double, vb.)
            //2: Değişken adı
            //3: In komutu
            //4: Liste, dizi veya koleksiyon adı

            //string[] cities = { "Prag", "Roma", "Paris", "Oslo", "Santorini" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number + " Çifttir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number + " Tektir.");
            //    }
            //}

            //int[] numbers = { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine("Toplam: " + total);

            //List<string> cities = new List<string> { "Prag", "Roma", "Paris", "Oslo", "Santorini" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //List<int> numbers = new List<int> { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba Dünya";

            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması


            Console.WriteLine("***** C# Eğitim Kampı Sınav Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıftaki öğrenci sayısını giriniz: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve sınav notlarını tutmak için diziler oluşturma
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                //Öğrenci ismini alma
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her Öğrenci için 3 sınav notu alma

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{i + 1}. öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double examResult = double.Parse(Console.ReadLine());
                    totalExamResult += examResult; //Notları toplamak için
                }

                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav Ortalamaları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçme durumu
                Console.WriteLine("------------------------------");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti!");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı!");
                }
            }

            





















            #endregion






















            Console.Read();
        }
    }
}
