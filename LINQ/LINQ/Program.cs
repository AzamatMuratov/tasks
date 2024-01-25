using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>
        {
            new Car { Brand = "Lexus", Model = "ES 250", Year = 2020,Price = "$53,340"},
            new Car { Brand = "Lexus", Model = "LX 570", Year = 2019, Price = "$89,999"},
            new Car { Brand = "Kia", Model = "K5", Year = 2021,Price = "$25,390"},
            new Car { Brand = "Honda", Model = "Accord", Year = 2021, Price = "$24,970"},
            new Car { Brand = "Hyundai", Model = "Elantra", Year = 2020 , Price = "$20,655"}
        };
        var priceFilter = cars.OrderByDescending(car => car.Price);
        Console.WriteLine("\nСписок машин, отсортированных по цене: ");
        PrintPrice(priceFilter);
        
        var filteredCars = cars.Where(car => car.Brand == "Lexus");
        Console.WriteLine("\nМодели машины \"Lexus\":");
        PrintCars(filteredCars);

        var sortedCars = cars.OrderByDescending(car => car.Year);
        Console.WriteLine("\nМодели машин, отсортированные по году выпуска (в порядке убывания):");
        PrintCars(sortedCars);

        var groupedCars = cars.GroupBy(car => car.Brand);
        Console.WriteLine("\nМодели машин по маркам:");
        foreach (var group in groupedCars)
        {
            Console.WriteLine($"Марка: {group.Key}");
            PrintCars(group);
            Console.WriteLine();
        }
    }

    static void PrintCars(IEnumerable<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} ({car.Year})");
        }
    }

    static void PrintPrice(IEnumerable<Car> cars)
    {
        foreach (var car  in cars)
        {
            Console.WriteLine($"{car.Brand} {car.Model} - {car.Price}");
        }
    }
}