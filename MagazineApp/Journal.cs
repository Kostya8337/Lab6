using System;

public class Journal : IComparable<Journal>
{
    public string Title { get; set; }
    public double Price { get; set; }
    public int Pages { get; set; }
    public int SalesRating { get; set; } // Рейтинг за шкалою 1-10

    // Конструктор
    public Journal(string title, double price, int pages, int salesRating)
    {
        Title = title;
        Price = price;
        Pages = pages;
        SalesRating = salesRating;
    }

    // Реалізація інтерфейсу IComparable для порівняння за ціною
    public int CompareTo(Journal other)
    {
        if (other == null) return 1;
        return this.Price.CompareTo(other.Price);
    }

    // Перевизначаємо метод ToString для зручного відображення
    public override string ToString()
    {
        return $"Назва: {Title}, Ціна: {Price} грн, Сторінки: {Pages}, Рейтинг продажів: {SalesRating}/10";
    }
}
