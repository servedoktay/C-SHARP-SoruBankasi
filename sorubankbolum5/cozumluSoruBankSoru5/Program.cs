using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Sayi Girin:");
            a = Convert.ToInt32(Console.ReadLine());

            if(a%2==0) Console.WriteLine("çift");
            else if (!(a % 2 == 0)) Console.WriteLine("tek");
            else Console.WriteLine("HATA");
            Console.ReadKey();
        }
    }
}
