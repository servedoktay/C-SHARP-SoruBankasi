using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBank_Soru6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dogrumu;
            Console.WriteLine("(15/3=5 )islemi sizce dogrumudur(true-false)");
            dogrumu =Convert.ToBoolean(Console.ReadLine());

            if (dogrumu) Console.WriteLine("iyi");
            else Console.WriteLine("kotu");
            Console.ReadKey();
        }
    }
}
