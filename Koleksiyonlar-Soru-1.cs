using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar-Soru-1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ArrayList sayilar = new ArrayList();
            bool canConvert = true;
            int pozitifDeger = 0;
            while (sayilar.Count != 20)
            {
                Console.WriteLine("Lütfen 1'den büyük pozitif bir tam sayı giriniz!");

                string s = Console.ReadLine();
                bool i2 = int.TryParse(s, out pozitifDeger);

                if (pozitifDeger < 2 || canConvert == false)
                {
                    Console.WriteLine("Geçerli bir sayı giriniz!");
                }
                else
                {
                    sayilar.Add(pozitifDeger);
                }
            }
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            int sayac = 0;
            foreach (int j in sayilar)
            {
                for (int l = 2; l <= j / 2; l++)
                {
                    if (j % l == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    asalSayilar.Add(j);
                }
                else
                {
                    asalOlmayanSayilar.Add(j);
                }
                sayac = 0;

            }
            int asalOrtalama = 0;
            int asalOlmayanOrtalama = 0;
            asalSayilar.Sort();
            asalOlmayanSayilar.Sort();
            foreach (int i1 in asalSayilar)
            {
                asalOrtalama += i1;
            }

            foreach (int i2 in asalOlmayanSayilar)
            {
                asalOlmayanOrtalama += i2;
            }

            for (int i4 = 0; i4 < asalSayilar.Count; i4++)
            {
                Console.WriteLine("{0}. Asal sayı = {1}", (i4 + 1), asalSayilar[i4]);
            }

            for (int i5 = 0; i5 < asalOlmayanSayilar.Count; i5++)
            {
                Console.WriteLine("{0}. Asal olmayan sayı = {1}", (i5 + 1), asalOlmayanSayilar[i5]);
            }

            Console.WriteLine("Asal Olan Toplam {0} Adet Sayı Vardır!", asalSayilar.Count);
            Console.WriteLine("Asal Olmayan Toplam {0} Adet Sayı Vardır! ", asalOlmayanSayilar.Count);
            Console.WriteLine("Asal olan sayıların ortalaması = " + asalOrtalama / asalSayilar.Count + " " + "Asal olmayan sayıların ortalaması = " + asalOlmayanOrtalama / asalOlmayanSayilar.Count);
            Console.ReadLine(); 
            }
}
}