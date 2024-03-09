using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Базовий клас Transport (Транспорт)
class Transport
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }

    // Конструктор
    public Transport(string model, string color, int year)
    {
        Model = model;
        Color = color;
        Year = year;
    }

    // Метод для виведення інформації про транспорт
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Color: {Color}, Year: {Year}");
    }
}

// Підклас Car (Автомобіль), успадковує клас Transport
class Car : Transport
{
    public int NumberOfDoors { get; set; }

    // Конструктор
    public Car(string model, string color, int year, int numberOfDoors) : base(model, color, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    // Перевизначений метод для виведення інформації про автомобіль
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of doors: {NumberOfDoors}");
    }
}

// Підклас Bike (Велосипед), успадковує клас Transport
class Bike : Transport
{
    public bool HasBasket { get; set; }

    // Конструктор
    public Bike(string model, string color, int year, bool hasBasket) : base(model, color, year)
    {
        HasBasket = hasBasket;
    }

    // Перевизначений метод для виведення інформації про велосипед
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has basket: {HasBasket}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів різних типів транспорту
        Transport vehicle1 = new Car("Toyota Camry", "Blue", 2020, 4);
        Transport vehicle2 = new Bike("Giant", "Red", 2019, true);

        // Виведення інформації про транспорт
        vehicle1.DisplayInfo();
        Console.WriteLine();
        vehicle2.DisplayInfo();
    }
}
