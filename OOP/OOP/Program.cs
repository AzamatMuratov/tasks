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

    public void YearDifference()
    {
        Console.WriteLine("Прошло с момента выпуска " + (2024 - Year) + " лет");
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
        Console.WriteLine($"Издавтельство: {PublishingHouse}");
        Console.WriteLine();
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
        Console.WriteLine($"Медиа платформа: {MediaPlatform}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("Богатый папа, бедный папа", "Робертом Т. Кийосаки", 1997, 336,"Techpress Inc.");
        Audiobook audiobook1 = new Audiobook("Как завоёвывать друзей и оказывать влияние на людей", "Дейл Карнеги", 1935, "Игорь Дунаев","spotify");
        MediaItem mediabook = new Audiobook("Магия утра", "Хэл Элрод", 2009, "Сергей Гончаров", "apple music");
        MediaItem mediabook1 = new MediaItem("Гарри поттер", "ads", 1998);
        mediabook1.DisplayInfo();
        Console.WriteLine();
        mediabook.YearDifference();
        mediabook.DisplayInfo();
        book1.DisplayInfo();
        audiobook1.YearDifference();
        audiobook1.DisplayInfo();
    }
}