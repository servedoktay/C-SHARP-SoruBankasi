using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cins;
            Console.Write("Cinsiyet Bilgisi Giriniz..:");
            cins=Convert.ToChar(Console.ReadKey().KeyChar);

            Console.WriteLine("\nCinsiyeti=\t{0}",cins=='e' ? "erkek": (cins == 'k' ? "kadın" : "geçersiz giriş"));
            Console.ReadKey();


        }
    }
}
