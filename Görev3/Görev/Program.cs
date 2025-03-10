using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan ilk sayıyı al
        Console.Write("Birinci sayıyı girin: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Kullanıcıdan ikinci sayıyı al
        Console.Write("İkinci sayıyı girin: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // İki sayının toplamını hesapla
        double sum = num1 + num2;

        // Sonucu ekrana yazdır
        Console.WriteLine($"\nGirilen sayıların toplamı: {sum}");
    }
}
