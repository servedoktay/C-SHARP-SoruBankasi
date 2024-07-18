using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBankSoru3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = new string[5];
            string gecici;

            // Kullanıcıdan 5 adet isim almak
            for (int i = 0; i < adlar.Length; i++)
            {
                Console.Write($"{i + 1}. ismi giriniz: ");
                adlar[i] = Console.ReadLine();
            }

            // İsimleri alfabetik olarak sıralamak
            for (int i = 0; i < adlar.Length - 1; i++)
            {
                for (int j = i + 1; j < adlar.Length; j++)
                {
                    if (string.Compare(adlar[i], adlar[j]) > 0)
                    {
                        gecici = adlar[i];
                        adlar[i] = adlar[j];
                        adlar[j] = gecici;
                    }
                }
            }

            // Sıralanmış isimleri yazdırmak
            Console.WriteLine("\nAlfabetik sıraya göre isimler:");
            foreach (var ad in adlar)
            {
                Console.WriteLine(ad);
            }

            Console.ReadKey();
            /* Detaylı Açıklama:
                    Kullanıcıdan İsim Almak:

                    csharp
                    Kodu kopyala
                    for (int i = 0; i < adlar.Length; i++)
                    {
                        Console.Write($"{i + 1}. ismi giriniz: ");
                        adlar[i] = Console.ReadLine();
                    }
                    Kullanıcıdan 5 adet isim alınıyor ve adlar dizisine atanıyor.

                    İsimleri Alfabetik Sıralamak:

                    csharp
                    Kodu kopyala
                    for (int i = 0; i < adlar.Length - 1; i++)
                    {
                        for (int j = i + 1; j < adlar.Length; j++)
                        {
                            if (string.Compare(adlar[i], adlar[j]) > 0)
                            {
                                string gecici = adlar[i];
                                adlar[i] = adlar[j];
                                adlar[j] = gecici;
                            }
                        }
                    }
                    İki for döngüsü kullanarak, dizinin elemanlarını alfabetik sıraya göre sıralıyor. string.Compare metodu, 
                    iki string değeri karşılaştırır ve eğer ilk string ikinci stringden büyükse pozitif bir değer döner.

                    Sıralanmış İsimleri Yazdırmak:

                    csharp
                    Kodu kopyala
                    foreach (var ad in adlar)
                    {
                        Console.WriteLine(ad);
                    }
                    foreach döngüsü kullanarak sıralanmış diziyi ekrana yazdırıyor.

                    Bu açıklamalar ve düzeltmelerle kodunuzu daha okunabilir ve hatasız hale getirmiş olduk.*/
        }
    }
}
