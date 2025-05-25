using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü [ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Yeşil";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Roma";
            //cities[1] = "Paris";
            //cities[2] = "Zürih";
            //cities[3] = "Oslo";
            //cities[4] = "Santorini";

            //Console.WriteLine(cities[1]);

            //int[] number = new int[10];
            //number[0] = 50;
            //number[1] = 48;
            //number[2] = 698;
            //number[3] = 24;
            //number[7] = 748;

            //Console.WriteLine(number[5]);

            //string[] cities = { "Prag", "Roma", "Paris", "Oslo", "Santorini" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Yeşil", "Mavi", "Beyaz", "Turuncu", "Siyah" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 45, 49, 321, 147, 412, 3566, 897, 745, 2355, 213, 114, 3574, 102 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] names = { "Ali", "Ayşe", "Fatma", "Mehmet", "Zeynep", "Ahmet" };
            //Console.WriteLine(names.Length);

            //int[] numbers = { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Ayşe", "Fatma", "Mehmet", "Zeynep", "Ahmet" };
            //int index = Array.IndexOf(customers, "Fatma");
            //Console.WriteLine("Fatma'nın indeksi: " + index);

            //int[] numbers = { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 4, 21, 465, 46549, 421, 4787, 899, 954, 5412, 2154, 6589, 4121, 1423, 4775, 1235 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //        sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //int[] numbers= { 21, 45, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("---------------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if ( numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            
            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("---------------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
