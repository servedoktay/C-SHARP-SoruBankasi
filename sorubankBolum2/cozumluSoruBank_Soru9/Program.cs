using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cozumluSoruBank_Soru9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random yer= new Random();
            //Console.SetWindowPosition(30, 20);

            for (int i = 0; i < 100; i++)
            {
                int satir =yer.Next(1,19);
                int sutun = yer.Next(1, 19);
                Console.SetCursorPosition(satir, sutun);
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(150);
                //priotary=oncelikli thread=iplik,parcacık suspends=askıya alma
                //thread acıklaması:creates and controls a thread,set is priority,and get status
                //bir iş parçacığı oluşturur ve kontrol eder, önceliği belirler ve durumu alır

            }
            /*
             * System.Threading.Thread.Sleep(150); kod satırı, çalışan programın belirtilen süre (milisaniye cinsinden) boyunca duraklatılmasını sağlar. Yani, bu kod satırı çalıştırıldığında program belirtilen süre kadar bekler ve daha sonra çalışmaya devam eder.

            Burada 150 değeri milisaniye cinsinden olduğu için, program bu satırı çalıştırdığında 150 milisaniye (0.15 saniye) boyunca duraklar. Bu tür duraklatma işlemleri genellikle şu durumlarda kullanılır:

            Animasyon veya Görsel Efektler: Konsol uygulamalarında veya grafiksel uygulamalarda belirli bir efektin veya animasyonun daha yavaş ve belirgin bir şekilde görünmesi için kullanılabilir.

            Arka Plan İşlemleri: Arka planda çalışan bir işlemi belirli aralıklarla kontrol etmek veya işlemek için beklemeye ihtiyaç duyulabilir.

            İş Parçacığı (Thread) Kontrolü: Çoklu iş parçacığı (thread) kullanan uygulamalarda, belirli bir iş parçacığının diğerleriyle senkronize edilmesi veya belirli bir süre boyunca durdurulması gerekebilir.

            Örneğin, eğer bir döngü içinde belirli aralıklarla bir işlem yapılıyorsa ve bu işlem arasında bir bekleme süresi gerekiyorsa, Thread.Sleep yöntemi kullanılabilir. Bu süreç, CPU kaynaklarını gereksiz yere tüketmemek ve programın istenilen hızda çalışmasını sağlamak için önemlidir.

            Ancak, Thread.Sleep kullanılırken dikkat edilmesi gereken bazı noktalar da vardır:

            Uygulamanın performansını etkileyebilir, çünkü Sleep metodunun çalıştığı süre boyunca işlemci kaynakları serbest bırakılır.
            Uygulama, Sleep süresince başka işler yapamaz. Bu yüzden gereksiz uzun sürelerde Sleep kullanmak, kullanıcı etkileşimini veya arka planda çalışan işlemleri engelleyebilir.
            Sonuç olarak, Thread.Sleep(150); kod satırı belirtilen süre boyunca programın durmasını sağlar ve daha sonra çalışmasına devam eder.*/
                        Console.ReadKey();
        }
    }
}
