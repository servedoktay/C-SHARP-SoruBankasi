using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char karakter;
            Console.WriteLine("Karakter Girin");
            karakter = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (char.IsLetter(karakter))
            {
                if (char.IsUpper(karakter)) Console.WriteLine("Buyuk");
                else if(char.IsLower(karakter)) Console.WriteLine("Kucuk");
            
            }
            //  if ((karakter >= 'A' && karakter <= 'Z')) Console.WriteLine("Buyuk");
            //else Console.WriteLine("kucuk");
            else Console.WriteLine("HARF girin");

            Console.ReadKey();
        }
    }
}
