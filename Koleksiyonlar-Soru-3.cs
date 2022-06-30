using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar-Soru-3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir cümle giriniz.");
            string cumle = Console.ReadLine();
            string cumle2 = cumle.Replace(" ", "");
            char[] dizi1 = cumle2.ToCharArray();
            char[] dizi2 = new char[16];
            dizi2[0] = 'A'; dizi2[1] = 'E'; dizi2[2] = 'I'; dizi2[3] = 'İ'; dizi2[4] = 'O'; dizi2[5] = 'Ö'; dizi2[6] = 'U'; dizi2[7] = 'Ü';
            dizi2[8] = 'a'; dizi2[9] = 'e'; dizi2[10] = 'ı'; dizi2[11] = 'i'; dizi2[12] = 'o'; dizi2[13] = 'ö'; dizi2[14] = 'u'; dizi2[15] = 'ü';
            ArrayList sesliHarf = new ArrayList();

            for (int i = 0; i < cumle2.Length; i++)
            {
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (dizi2[j] == dizi1[i])
                    {
                        sesliHarf.Add(dizi2[j]);
                    }
                }
            }

            for (int k = 0; k < sesliHarf.Count; k++)
            {
                for (int l = 0; l < sesliHarf.Count; l++)
                {
                    if (sesliHarf[l] == sesliHarf[k])
                        sesliHarf.RemoveAt(l);
                }
            }

            sesliHarf.Sort();
            foreach (var c in sesliHarf)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
}
}
}