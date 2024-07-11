using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Ay;
            Console.WriteLine("Ay Giriniz");
            Ay = Console.ReadLine();
            switch (Ay)
            {
                case "Aralik":
                case "Ocak":
                case "Subat":
                    Console.WriteLine("KIŞ");
                    break;

                case "Nisan":
                case "Mayis":
                Console.WriteLine("İlkBahar");
                    break;

                case "Haziran":
                case "Temmuz":
                case "Ağustos":
                    Console.WriteLine("YAZ");
                    break;

                case "Eylul":
                case "Ekim":
                case "Kasim":
                    Console.WriteLine("Sonbahar");

                    break;

                default:Console.WriteLine("Hata");
                    break;
            }
            Console.ReadKey();
        }
    }
}
