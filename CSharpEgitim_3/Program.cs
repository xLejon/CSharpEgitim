﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitim_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If - Else

            //Console.Write("Lütfen şifre giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış!");
            //}


            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{

            //    Console.Write("Veriler Doğrulandı");

            //}

            //else
            //{
            //    Console.Write("Hatalı Giriş!");
            //}


            //int number;

            //Console.Write("Sayıyı Giriniz: ");

            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}


            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("1.Sınav Sonucu: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sınav Sonucu: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3.Sınav Sonucu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 +  exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama Sınav Puanı: " + average);


            //if (average > 0 & average <= 50)
            //{
            //    result = "Düşük Sınav Ortalaması";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Orta Sınav Ortalaması";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "İyi Sınav Ortalaması";
            //}
            //if (average > 84)
            //{ 
            //    result = "Çok İyi Sınav Ortalaması";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            // != belirtilen değerden farklıysa, eşit değilse.

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz!");
            //}

            #endregion

            #region Mod İşlemleri


            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //    int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan sonuç: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları


            //char team;
            //Console.Write("Lütfen bir takım sembolü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoranı ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- Ana Yemekler ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kori Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("---------------- Ana Yemekler ----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- Çorbalar ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //    Console.WriteLine("2- Arabaşı Çorbası");
            //    Console.WriteLine("---------------- Çorbalar ----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- Pizzalar ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Margaritha");
            //    Console.WriteLine("2- Kebab Pizza");
            //    Console.WriteLine("3- Tavuklu Pizza");
            //    Console.WriteLine("---------------- Pizzalar ----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- İçecekler ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Fanta");
            //    Console.WriteLine("3- Ayran");
            //    Console.WriteLine("4- Su");
            //    Console.WriteLine("---------------- İçecekler ----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------- Tatlılar ----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("---------------- Tatlılar ----------------");

            //    Console.WriteLine();
            //}














            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Giriş"); break;
            //}

            #endregion

            #region Switch Case Calculator

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak  istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpımı: " + result);
            //        break;
                
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölümü: " + result);
            //        break;
            //}


            #endregion
            
            
            
            
            
            
            
            
            
            
            Console.Read();

        }
    }
}
