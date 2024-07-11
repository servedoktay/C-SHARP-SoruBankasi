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
            char karakter;
            Console.WriteLine("Karakter Girişi");
            karakter = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();

            //if(char.IsDigit(karakter)) { Console.WriteLine("\nSayi"); }
            //else if (char.IsLetter(karakter)) { Console.WriteLine("\nHarf"); }
            //else Console.WriteLine("\nOzel Karakter");


            //yada 
            if ((karakter >= 'A' && karakter <= 'Z') || (karakter >='a'&&karakter<='z')) { Console.WriteLine("HARF tusuna basildi"); }
            else if ((karakter >= '0' && karakter <= '9') ) { Console.WriteLine("RAKAM tusuna basildi"); }
            else if (!(karakter >= 'A' && karakter <= 'Z') || (karakter >= 'a' && karakter <= 'z')|| (karakter >= '0' && karakter <= '9')) { Console.WriteLine("OZEL KARAKTER tusuna basildi"); }

            /*Açıklama:
            Karakter Girişi Alınması:

            Console.ReadKey().KeyChar, konsoldan girilen tek bir tuş vuruşunu alır ve bu tuşun karakter değerini döndürür.
            Convert.ToChar() ile KeyChar'ı açık bir şekilde char türüne dönüştürürüz.
            Karakter Sınıflandırması:

            İlk if koşulu, karakter'in büyük veya küçük harf olup olmadığını ASCII değerlerini kullanarak kontrol eder.
            İkinci else if koşulu, karakter'in rakam (0-9) olup olmadığını ASCII değerleri ile kontrol eder.
            else bloğu, yukarıdaki kategorilere uymayan herhangi bir karakteri özel karakter olarak kabul eder.
            Çıktı:

            Koşulların hangisinin doğru olduğuna bağlı olarak, basılan tuşun harf, rakam veya özel karakter olduğunu belirten bir mesaj yazdırılır.
            Bu düzeltilmiş kod, artık harfler, rakamlar ve özel karakterler için doğru ASCII değer aralıklarını kullanarak tuşların türünü doğru bir şekilde belirleyecektir.*/

            Console.ReadKey();
        }
    }
}
