using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBank_Soru4
{
    internal class Program
    {
        public enum aylar
        {
            Ocak,Subat,Mart,
            Nisan,MAyis,Haziran,
            Temmuz,Ağustos,Eylul,
            Ekim,Kasim,Aralik
        }
        
        static void Main(string[] args)
        {
            int ay;
            Console.WriteLine("Ay Giriniz(0-12)");
            ay = Convert.ToInt32(Console.ReadLine()) - 1;
            aylar ayadi;
            ayadi = (aylar)ay;
            Console.WriteLine(ayadi);
            Console.ReadKey();

            //int sayıları ,lu bolmek
            int a =39, b = 5;
            double bolum = (double)a / b;
            Console.WriteLine(bolum);
            Console.ReadKey();
        }
    }
}
