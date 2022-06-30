using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar-Soru-2
{
    internal class Program
    {
        static void Main(string[] args)
        {


           int [] dizi = new int [20];
            Console.WriteLine("Lütfen 20 adet tam sayı giriniz.");

            for (int i = 0; i < 20; i++)
            {

            dizi[i]= (int.Parse(Console.ReadLine()));
            }

            Array.Sort(dizi);
            Array.Reverse(dizi);

            int enBuyuk = dizi[0] + dizi[1] + dizi[2];
            int enKucuk = dizi[17] + dizi[18] + dizi[19];

            Console.WriteLine("Dizinin en büyük 3 sayısı= {0}{1}{2}{3}{4}", dizi[0], " ", dizi[1], " ", dizi[2]);
            Console.WriteLine("Dizinin en küçük 3 sayısı= {0}{1}{2}{3}{4}", dizi[17], " ", dizi[18], " ", dizi[19]);
            Console.WriteLine("En büyük 3'lünün ortalaması= " + (enBuyuk/3));
            Console.WriteLine("En küçük 3'lünün ortalaması= " + (enKucuk / 3));
            Console.WriteLine("Ortalamalar Toplamı= " + ((enBuyuk/3)+ (enKucuk/3)));
            Console.ReadLine();
            }
}
}