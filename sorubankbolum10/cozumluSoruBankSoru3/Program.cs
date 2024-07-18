internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sayi gir");
        int sayi=Convert.ToInt32(Console.ReadLine());

        kareAl(sayi);

    
    }
    static void kareAl(int sayi)
    {
        Console.WriteLine($"{sayi} Sayisinin Karesi={sayi*sayi}");
    }
}