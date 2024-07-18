using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi 1..:");
            int sayi1=int.Parse(Console.ReadLine());


            Console.WriteLine("Sayi 2..:");
            int sayi2 = int.Parse(Console.ReadLine());

            Topla(sayi1, sayi2);
            Carp(sayi1, sayi2);
            Console.ReadKey();
        }
        static void Topla(int sayi1,int sayi2)
        {
            Console.WriteLine($"{sayi1}  +   {sayi2}  =   {sayi1+sayi2}");
        }
        static void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine($"{sayi1}  x   {sayi2}  =   {sayi1 * sayi2}");
        }
    }
}
