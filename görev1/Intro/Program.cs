using System;
using System.Linq; // Linq kütüphanesi Max() fonksiyonu için gerekli

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];

        // Kullanıcıdan 5 sayı al
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Diziyi ekrana yazdır
        Console.WriteLine("\nGirilen sayılar: " + string.Join(", ", numbers));

        // En büyük sayıyı bul
        int maxNumber = numbers.Max();

        Console.WriteLine($"\nDizideki en büyük sayı: {maxNumber}");
    }
}
