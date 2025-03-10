using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan adını al
        Console.Write("Lütfen adınızı girin: ");
        string name = Console.ReadLine();

        // Kullanıcının adını ekrana yazdır
        Console.WriteLine($"\nMerhaba, {name}!");
    }
}
