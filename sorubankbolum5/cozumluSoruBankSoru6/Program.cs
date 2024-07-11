 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cinsiyet, askerlik;
            int yas;

            Console.WriteLine("Cins=(E-K)");
            cinsiyet = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("Askerlik=(E-H)");
            askerlik=Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("Yas");
            yas=int.Parse(Console.ReadLine());

            if(cinsiyet=='E'&&askerlik=='E'&&yas<=30) Console.WriteLine("İşe Alindiniz");
            else if((cinsiyet=='E')&&(askerlik=='E')&&(yas<=30)) Console.WriteLine("İşe Alinmadin");
            else Console.WriteLine("HATA");

            Console.ReadKey();

        }
    }
}
