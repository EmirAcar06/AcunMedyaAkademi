using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Sayının rakamlarının toplamı
        Console.Write("Bir sayı girin: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int temp = number; temp > 0; temp /= 10)
        {
            sum += temp % 10;
        }
        Console.WriteLine($"Rakamların toplamı: {sum}");

        // 2. Kullanıcıdan belirli aralıkta sayı alma
        int userNumber;
        do
        {
            Console.Write("10 ile 100 arasında bir sayı girin: ");
            userNumber = Convert.ToInt32(Console.ReadLine());
        } while (userNumber < 10 || userNumber > 100);

        // 3. Yaş kategorileri
        List<int> ages = new List<int> { 5, 16, 25, 70 };
        foreach (int age in ages)
        {
            if (age <= 12) Console.WriteLine($"{age} yaş: Çocuk");
            else if (age <= 19) Console.WriteLine($"{age} yaş: Genç");
            else if (age <= 64) Console.WriteLine($"{age} yaş: Yetişkin");
            else Console.WriteLine($"{age} yaş: Yaşlı");
        }

        // 4. Tekrar eden elemanları bulma
        int[] array = { 1, 2, 3, 2, 4, 5, 3, 1 };
        var duplicates = array.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Tekrar eden elemanlar: " + string.Join(", ", duplicates));

        // 5. En uzun ve en kısa kelimeyi bulma
        string[] words = { "elma", "armut", "karpuz", "çilek" };
        string shortest = words.OrderBy(w => w.Length).First();
        string longest = words.OrderByDescending(w => w.Length).First();
        Console.WriteLine($"En kısa kelime: {shortest}, En uzun kelime: {longest}");

        // 6. Cümleyi diziye kaydedip alfabetik sıralama
        Console.Write("Bir cümle girin: ");
        string sentence = Console.ReadLine();
        string[] wordArray = sentence.Split(' ').OrderBy(w => w).ToArray();
        Console.WriteLine("Alfabetik sıralı kelimeler: " + string.Join(", ", wordArray));

        // 7. String dizisini genişletme
        List<string> dynamicList = new List<string> { "elma", "armut" };
        dynamicList.Add("çilek");
        Console.WriteLine("Liste: " + string.Join(", ", dynamicList));

        // 8. Kullanıcıdan kelimeler alıp tersten yazdırma
        List<string> userWords = new List<string>();
        Console.Write("Bir kelime girin (çıkmak için boş bırakın): ");
        string input;
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            userWords.Add(input);
        }
        userWords.Reverse();
        Console.WriteLine("Tersten: " + string.Join(", ", userWords));

        // 9. Rastgele sayılar alıp ortalama hesaplama ve sıralama
        List<int> numbers = new List<int>();
        Console.Write("Kaç adet sayı girmek istersiniz? ");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{i + 1}. Sayıyı girin: ");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }
        numbers.Sort();
        Console.WriteLine("Sıralı liste: " + string.Join(", ", numbers));
        Console.WriteLine("Ortalama: " + numbers.Average());

        // 10. 10'dan küçükleri silme
        numbers.RemoveAll(n => n < 10);
        Console.WriteLine("10'dan küçükler silindi: " + string.Join(", ", numbers));

        // 11. 50’nin altındaki notları 50 yapma
        List<int> grades = new List<int>();
        Console.Write("Kaç adet not girmek istersiniz? ");
        int gradeCount = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < gradeCount; i++)
        {
            Console.Write($"{i + 1}. Notu girin: ");
            grades.Add(Convert.ToInt32(Console.ReadLine()));
        }
        grades = grades.Select(g => g < 50 ? 50 : g).ToList();
        Console.WriteLine("Güncellenmiş notlar: " + string.Join(", ", grades));
    }
}
