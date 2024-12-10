using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1️⃣ Створення колекції журналів
        List<Journal> journalCollection = new List<Journal>
        {
            new Journal("Наука і техніка", 150, 45, 8),
            new Journal("АвтоСвіт", 100, 60, 9),
            new Journal("Модний журнал", 200, 30, 7),
            new Journal("Технології майбутнього", 180, 50, 10),
            new Journal("Спорт для всіх", 80, 40, 6)
        };

        Console.WriteLine("\n🔹 Список журналів:");
        foreach (var journal in journalCollection)
        {
            Console.WriteLine(journal);
        }

        // 2️⃣ Сортування за ціною
        Console.WriteLine("\n🔹 Сортування за ціною:");
        journalCollection.Sort();
        foreach (var journal in journalCollection)
        {
            Console.WriteLine(journal);
        }

        // 3️⃣ Сортування за кількістю сторінок
        Console.WriteLine("\n🔹 Сортування за кількістю сторінок:");
        JournalComparer comparer = new JournalComparer();
        journalCollection.Sort(comparer);
        foreach (var journal in journalCollection)
        {
            Console.WriteLine(journal);
        }

        // 4️⃣ Сортування за рейтингом продажів
        Console.WriteLine("\n🔹 Сортування за рейтингом продажів:");
        journalCollection.Sort((x, y) => comparer.CompareBySalesRating(x, y));
        foreach (var journal in journalCollection)
        {
            Console.WriteLine(journal);
        }

        Console.WriteLine("\n✅ Програма завершена.");
    }
}
