using System;
using System.Collections.Generic;

public class JournalComparer : IComparer<Journal>
{
    // Визначаємо спосіб порівняння за кількістю сторінок
    public int CompareByPages(Journal x, Journal y)
    {
        if (x == null || y == null) throw new ArgumentException("Об'єкти не можуть бути null");
        return x.Pages.CompareTo(y.Pages);
    }

    // Визначаємо спосіб порівняння за рейтингом продажів
    public int CompareBySalesRating(Journal x, Journal y)
    {
        if (x == null || y == null) throw new ArgumentException("Об'єкти не можуть бути null");
        return x.SalesRating.CompareTo(y.SalesRating);
    }

    // Реалізація IComparer з порівнянням за кількістю сторінок
    public int Compare(Journal x, Journal y)
    {
        return CompareByPages(x, y);
    }
}
