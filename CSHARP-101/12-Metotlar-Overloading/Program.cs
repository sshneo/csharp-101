﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace _12_Metotlar_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            //Metot Aşırı Yükleme - Overloading

            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);
            //Metot İmzası
            //MetodAdı + parametre sayisi + parametre


            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            


        }

        class  Metotlar
        {
            public void Topla(int a,int b,out int toplam)
            {

                toplam = a+b;

            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);

            }
            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);

            }

           

        }
    }
}
