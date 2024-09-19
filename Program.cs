using System;
using System.Linq;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array Docs
            //string[] sayilar = { "11", "22", "33", "44", "55", "33", "11", "22", "33", "33", "44", "55" };
            //string[] sayilar2 = new string[8];

            //Console.WriteLine(Array.IndexOf(sayilar, "33"));
            //Console.WriteLine(Array.LastIndexOf(sayilar, "33"));
            //Console.WriteLine(sayilar.Contains("55"));

            //Console.WriteLine(sayilar.Max());
            //Console.WriteLine(sayilar.Min());

            //Array.Copy(sayilar,sayilar2,8);
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] sayilar3 = (string[])sayilar.Clone();

            //Array.Resize(ref sayilar, 12);//Boyut rezerve

            #endregion

            //int[,] dizi = new int[5, 3];
            //Random rnd = new Random();

            //for (int i = 0; i < 5; i++) {
            //    for (int j = 0; j < 3; j++)
            //    {
            //        dizi[i, j] = rnd.Next(1, 10);
            //        Console.Write(dizi[i, j] + " | ");
            //    }
            //    Console.WriteLine();
            //}
            #region Ödev1
            string[,] dersProg = new string[30, 5]; //8 Ders 5 Gün
            string[] dersler = { "Güneşli", "Yağmurlu", "Bulutlu", "Parçalı Bulut", "Çok Bulutlu" };
            Random rnd = new Random();

            Console.WriteLine("09 : 00  |\t 12 : 00  | \t15 : 00  | \t 18 : 00  | \t 21 : 00");
            Console.WriteLine("------------------------------------------------------------------------");

            for (int satir = 0; satir < 30; satir++)
            {
                for (int sutun = 0; sutun < 5; sutun++)
                {
                    dersProg[satir, sutun] = dersler[rnd.Next(dersler.Length)];
                    Console.Write($"{dersProg[satir, sutun]}({rnd.Next(15, 31)}) || ");
                }
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("\n\n********************************************************************\n\n");

            #region Ödev 2
            string[] markalar = { "Fiat", "Renault", "VW", "Opel", "Ford" };
            int[,] satislar = {
            { 700, 600, 650 },  // Fiat
            { 900, 800, 700 },  // Renault
            { 300, 400, 350 },  // VW
            { 500, 450, 470 },  // Opel
            { 600, 500, 480 }   // Ford
            };

            // Tabloyu yazdırma
            Console.WriteLine("Marka\tOcak\tŞubat\tMart");
            for (int i = 0; i < markalar.Length; i++)
            {
                Console.Write(markalar[i] + "\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(satislar[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //a. Her marka için 3 aylık satış toplamı nedir? (Tablodaki satır toplamları) 
            Console.WriteLine("\nHer marka için 3 aylık satış toplamı:");
            for (int i = 0; i < markalar.Length; i++)
            {
                int toplam = 0;
                for (int j = 0; j < 3; j++)
                {
                    toplam += satislar[i, j];
                }
                Console.WriteLine($"{markalar[i]}: {toplam}");
            }
            // b. Her ay için tüm markaların satış toplamları (sütun toplamları)
            Console.WriteLine("\nHer ay için tüm markaların satış toplamı:");
            for (int j = 0; j < 3; j++)
            {
                int toplam = 0;
                for (int i = 0; i < markalar.Length; i++)
                {
                    toplam += satislar[i, j];
                }
                Console.WriteLine($"Ay {j + 1}: {toplam}");
            }

            // c. Her marka için en çok satışın gerçekleştirildiği ay (satırlardaki en büyük eleman)
            Console.WriteLine("\nHer marka için en çok satışın gerçekleştirildiği ay:");
            for (int i = 0; i < markalar.Length; i++)
            {
                int enYuksek = satislar[i, 0];
                int ay = 1;
                for (int j = 1; j < 3; j++)
                {
                    if (satislar[i, j] > enYuksek)
                    {
                        enYuksek = satislar[i, j];
                        ay = j + 1;
                    }
                }
                Console.WriteLine($"{markalar[i]}: Ay {ay} ({enYuksek} satış)");
            }

            // d. Her ay için en çok satışın gerçekleştirildiği marka (sütunlardaki en büyük eleman)
            Console.WriteLine("\nHer ay için en çok satışın gerçekleştirildiği marka:");
            for (int j = 0; j < 3; j++)
            {
                int enYuksek = satislar[0, j];
                string marka = markalar[0];
                for (int i = 1; i < markalar.Length; i++)
                {
                    if (satislar[i, j] > enYuksek)
                    {
                        enYuksek = satislar[i, j];
                        marka = markalar[i];
                    }
                }
                Console.WriteLine($"Ay {j + 1}: {marka} ({enYuksek} satış)");
            }

            // e. Tüm marka ve tüm aylar için otomobil satışları toplamı (tablonun genel toplamı)
            int genelToplam = 0;
            for (int i = 0; i < markalar.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    genelToplam += satislar[i, j];
                }
            }
            Console.WriteLine($"\nTüm marka ve tüm aylar için otomobil satışları toplamı: {genelToplam}");
            #endregion
            Console.ReadLine(); 
        }
    }
}