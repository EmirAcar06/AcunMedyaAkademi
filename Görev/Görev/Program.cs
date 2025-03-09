using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.Write("Bir sayı girin: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;
        for (int i = 1; i <= n; i++)
        {
            toplam += i;
        }

        Console.WriteLine("Toplam: " + toplam);
    }
}
