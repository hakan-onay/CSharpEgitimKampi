using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            //Console.Read();
            #endregion

            #region Değişkenler

            // string
            // Değişken_türü değişken_adı

            //string name = "Murat";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 512 545 56 23";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Müşteri: " +  customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşe";
            //customerSurname = "Kaya";
            //customerPhone = "+90 452 154 56 32";
            //customerEmail = "deneme2@gmail.com";
            //district = "Bayrampaşa";
            //city = "İstanbul";

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------");

            #endregion

            #region Int Değişkenler

            // int
            //int number = 5;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 20;
            int waterprice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("---- Kola: " + cokePrice + "TL");
            Console.WriteLine("---- Su: " + waterprice + "TL");
            Console.WriteLine("---- Patates Kızartması: " + friesPrice + "TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCounter;
            int cokeCounter;
            int waterCounter;
            int friesCounter;
            int pizzaCounter;
            int lemonadeCounter;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCounter = 3;
            cokeCounter = 3;
            waterCounter = 3;
            friesCounter = 3;
            pizzaCounter = 0;
            lemonadeCounter = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCounter;
            totalCokePrice = cokePrice * cokeCounter;
            totalWaterPrice = waterprice * waterCounter;
            totalFriesPrice = friesPrice * friesCounter;
            totalPizzaPrice = pizzaPrice * pizzaCounter;
            totalLemonadePrice = lemonadePrice * lemonadeCounter;


            Console.WriteLine("------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice);
            Console.WriteLine("Kola Tutarı: " + totalCokePrice);
            Console.WriteLine("Su Tutarı: " + totalWaterPrice);
            Console.WriteLine("Patates Kızartması Tutarı: " + totalFriesPrice);
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice);
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice);

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");

            #endregion

            Console.Read();


        }
    }
}
