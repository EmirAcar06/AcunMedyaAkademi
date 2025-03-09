using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }

        Console.Write("Bir sayı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        if (sayi1 > 0)
        {
            Console.WriteLine("Girilen sayı pozitiftir.");
        }
        else if (sayi1 < 0)
        {
            Console.WriteLine("Girilen sayı negatiftir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı sıfırdır.");
        }


    }
}
