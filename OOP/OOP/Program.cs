using System;

class MediaItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public MediaItem(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Год выпуска: {Year}");
    }
}

class Book : MediaItem
{
    public int PageCount { get; set; }
    public string PublishingHouse { get; set; }
    public Book(string title, string author, int year, int pageCount,string publishingHouse)
        : base(title, author, year)
    {
        PageCount = pageCount;
        PublishingHouse = publishingHouse;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество страниц: {PageCount}");
        Console.WriteLine($"Издавтельство: {PublishingHouse}\n");
    }
}

class Audiobook : MediaItem
{
    public string Narrator { get; set; }
    public string MediaPlatform { get; set; }
    public Audiobook(string title, string author, int year, string narrator,string mediaPlatform)
        : base(title, author, year)
    {
        Narrator = narrator;
        MediaPlatform = mediaPlatform;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Чтец: {Narrator}");
        Console.WriteLine($"Медиа платформа: {MediaPlatform}\n");
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("Преступление и наказание", "Федор Достоевский", 1866, 671,"macmillan");
        Audiobook audiobook1 = new Audiobook("1984", "Джордж Оруэлл", 1949, "Игорь Дунаев","spotify");

        book1.DisplayInfo();
        audiobook1.DisplayInfo();
    }
}