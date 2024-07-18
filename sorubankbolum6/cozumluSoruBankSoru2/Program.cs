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
            int[] a = new int[5];
            int sayac1, sayac2, gecicideger;
            for (sayac1 = 0; sayac1 < a.Length; sayac1++)
            {
                Console.WriteLine($"{sayac1+1}.sayiyi giriniz");
                a[sayac1] =Convert.ToInt32(Console.ReadLine());

            }
            for (sayac1 = 0; sayac1 < 4; sayac1++)
            {
                for (sayac2 = sayac1 + 1; sayac2 < 5; sayac2++)
                {
                    if (a[sayac1] < a[sayac2])
                    {
                        gecicideger= a[sayac1];
                        a[sayac1] = a[sayac2];
                        a[sayac2]= gecicideger;
                    }
                    
                }
                Console.WriteLine();
            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
                /* Açıklamalar:
    Dizi ve Değişken Tanımları:

    int[] a = new int[5]; ve int geciciDeger; tanımları yapılır.
    Kullanıcıdan 5 adet sayı alma:

    Kullanıcıdan 5 adet sayı girişi alınır ve diziye atanır.
    for döngüsü kullanarak 5 adet sayı girişi istenir ve alınan sayılar diziye eklenir.
    Büyükten küçüğe sıralama:

    İki iç içe for döngüsü kullanılarak dizideki sayılar büyükten küçüğe doğru sıralanır.
    if koşulu kullanılarak sıralama işlemi yapılır ve geçici değişken (geciciDeger) kullanılarak yer değiştirme işlemi gerçekleştirilir.
        Sıralanmış diziyi yazdırma:

        foreach döngüsü kullanılarak sıralanmış dizi ekrana yazdırılır.
        Bu iyileştirmeler, kodun daha okunabilir ve anlaşılır olmasını sağlar. Ek olarak, kullanıcıya daha net mesajlar verilerek kullanıcı deneyimi artırılmıştır.

                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] < a[j])
                        {
                            geciciDeger = a[i];
                            a[i] = a[j];
                            a[j] = geciciDeger;
                        }
                    }
                }
         koddaki bu satırları detaylı anlatırmısın ne iş yapıyor
        ChatGPT
        Tabii, bu kod parçası, bir dizideki elemanları büyükten küçüğe sıralamak için kullanılan bir kabarcık sıralama (bubble sort) algoritmasının bir varyasyonudur. Aşağıda bu kodun adım adım ne yaptığını detaylı bir şekilde açıklayacağım.

        Kod Parçası:
        csharp
        Kodu kopyala
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] < a[j])
                {
                    int geciciDeger = a[i];
                    a[i] = a[j];
                    a[j] = geciciDeger;
                }
            }
        }
        Detaylı Açıklama:
        1. Dış Döngü:
        csharp
        Kodu kopyala
        for (int i = 0; i < a.Length - 1; i++)
        Bu döngü i indeksini 0'dan başlatır ve dizinin uzunluğunun bir eksiğine (a.Length - 1) kadar devam eder.
        i, sıralamanın kaçıncı turunda olduğumuzu belirtir ve her turda dizinin i'den sonraki elemanları ile karşılaştırma yapar.
        2. İç Döngü:
        csharp
        Kodu kopyala
        for (int j = i + 1; j < a.Length; j++)
        Bu döngü j indeksini i + 1'den başlatır ve dizinin sonuna (a.Length) kadar devam eder.
        j, her turda i'den sonraki elemanları temsil eder ve bu elemanlarla karşılaştırma yapılır.
        3. Karşılaştırma ve Değişim:
        csharp
        Kodu kopyala
        if (a[i] < a[j])
        {
            int geciciDeger = a[i];
            a[i] = a[j];
            a[j] = geciciDeger;
        }
        if (a[i] < a[j]): Bu koşul, dizinin i indeksindeki elemanın, j indeksindeki elemandan küçük olup olmadığını kontrol eder.
        Eğer a[i] değeri a[j] değerinden küçükse, bu iki elemanın yerlerini değiştirmek için aşağıdaki işlemler yapılır:

        Geçici Değişken Kullanımı:

        csharp
        Kodu kopyala
        int geciciDeger = a[i];
        geciciDeger, a[i] değerini geçici olarak tutar.
        Yer Değiştirme:

        csharp
        Kodu kopyala
        a[i] = a[j];
        a[i], a[j] değerini alır.
        Geçici Değeri Atama:

        csharp
        Kodu kopyala
        a[j] = geciciDeger;
        a[j], başlangıçta a[i]'nin tuttuğu değeri, yani geciciDeger'i alır.
        Özet:
        Bu kod parçası, diziyi sıralamak için aşağıdaki adımları tekrarlar:

        i ve j indeksleri ile dizinin her elemanını diğer elemanlarla karşılaştırır.
        Eğer a[i] elemanı a[j] elemanından küçükse, bu iki elemanın yerlerini değiştirir.
        Bu işlemi tüm dizi elemanları için tekrar eder, böylece en büyük eleman en öne, en küçük eleman ise en sona doğru yerleşir.
        Çalışma Örneği:
        Diyelim ki a dizisi şu şekilde:

        css
        Kodu kopyala
        a = [3, 1, 4, 1, 5]
        İlk tur (i = 0):

        j = 1: 3 ile 1 karşılaştırılır, 3 > 1, değişim yok.
        j = 2: 3 ile 4 karşılaştırılır, 3 < 4, yer değiştirir: a = [4, 1, 3, 1, 5]
        j = 3: 4 ile 1 karşılaştırılır, 4 > 1, değişim yok.
        j = 4: 4 ile 5 karşılaştırılır, 4 < 5, yer değiştirir: a = [5, 1, 3, 1, 4]
        İkinci tur (i = 1):

        j = 2: 1 ile 3 karşılaştırılır, 1 < 3, yer değiştirir: a = [5, 3, 1, 1, 4]
        j = 3: 3 ile 1 karşılaştırılır, 3 > 1, değişim yok.
        j = 4: 3 ile 4 karşılaştırılır, 3 < 4, yer değiştirir: a = [5, 4, 1, 1, 3]
        Üçüncü tur (i = 2):

        j = 3: 1 ile 1 karşılaştırılır, 1 == 1, değişim yok.
        j = 4: 1 ile 3 karşılaştırılır, 1 < 3, yer değiştirir: a = [5, 4, 3, 1, 1]
        Dördüncü tur (i = 3):

        j = 4: 1 ile 1 karşılaştırılır, 1 == 1, değişim yok.
        Sonuç olarak, dizi a = [5, 4, 3, 1, 1] olarak sıralanır.*/

        }
    }
}
