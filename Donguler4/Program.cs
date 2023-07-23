using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 10 arasi sayilarin toplamını hesaplayan kod blogu
            //int toplam = 0;
            //int i;

            //for (i = 1; i <= 10; i++)
            //{
            //    toplam = toplam + i;
            //}

            //Console.WriteLine(toplam);


            // 1 - 20 arası sayıların toplamını hesaplayan kod blogu
            //int toplam = 0;
            //int i;

            //for (i = 1; i <= 20; i++)
            //{
            //    toplam = toplam + i;
            //}

            //Console.WriteLine(toplam);


            // 5! (faktöriyel) sonucunu hesaplayan donguyu yazın;
            int faktöriyel = 1;
            int i;

            for (i = 5; i >= 1; i-- )
            {
                faktöriyel = faktöriyel * i;
            }

            Console.WriteLine(faktöriyel);


            Console.Read();
        }
    }
}
