using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList arr = new ArrayList();

            // ArrayList'e eleman ekleme
            Console.WriteLine("Add Metodu İle");
            arr.Add(1);
            arr.Add(100);
            arr.Add("Oktay");
            arr.Add("ATAKUL");
            arr.Add(5.5);
            arr.Add(15.78);

            // ArrayList'i yazdırma
            Console.WriteLine("Elemanlar:");
            Okut(arr);

            Console.WriteLine("\nInsert metodu ile:");

            // Belirli pozisyona eleman ekleme
            arr.Insert(3, 26);
            arr.Insert(4, "Served");

            // ArrayList'i tekrar yazdırma
            Okut(arr);

            Console.ReadKey();
        }

        public static void Okut(ArrayList oku)
        {
            foreach (var i in oku)
            {
                Console.WriteLine(i);
            }
        }
    }
}
