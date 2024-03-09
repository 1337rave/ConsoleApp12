using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Базовий клас Device (Пристрій)
class Device
{
    public string Name { get; set; }

    // Конструктор з параметром для встановлення назви пристрою
    public Device(string name)
    {
        Name = name;
    }

    // Метод, що відтворює звук пристрою
    public virtual void Sound()
    {
        Console.WriteLine($"*Silent*"); // Звук за замовчуванням
    }

    // Метод, що відображає назву пристрою
    public void Show()
    {
        Console.WriteLine($"Device: {Name}");
    }

    // Метод, що відображає опис пристрою (загальний опис)
    public virtual void Desc()
    {
        Console.WriteLine($"This is a general device: {Name}");
    }
}

// Підклас Kettle (Чайник), успадковує клас Device
class Kettle : Device
{
    public string Type { get; set; }

    // Конструктор з параметром для встановлення назви та типу чайника
    public Kettle(string name, string type) : base(name)
    {
        Type = type;
    }

    // Перевизначений метод, що відображає опис чайника
    public override void Desc()
    {
        Console.WriteLine($"This is a {Type} kettle: {Name}");
    }
}

// Підклас Microwave (Мікрохвильовка), успадковує клас Device
class Microwave : Device
{
    public int Power { get; set; }

    // Конструктор з параметром для встановлення назви та потужності мікрохвильовки
    public Microwave(string name, int power) : base(name)
    {
        Power = power;
    }

    // Перевизначений метод, що відображає опис мікрохвильовки
    public override void Desc()
    {
        Console.WriteLine($"This is a {Power}W microwave: {Name}");
    }
}

// Підклас Car (Автомобіль), успадковує клас Device
class Car : Device
{
    public string Brand { get; set; }

    // Конструктор з параметром для встановлення назви та бренду автомобіля
    public Car(string name, string brand) : base(name)
    {
        Brand = brand;
    }

    // Перевизначений метод, що відображає опис автомобіля
    public override void Desc()
    {
        Console.WriteLine($"This is a {Brand} car: {Name}");
    }
}

// Підклас Steamship (Пароплав), успадковує клас Device
class Steamship : Device
{
    public string Country { get; set; }

    // Конструктор з параметром для встановлення назви та країни пароплава
    public Steamship(string name, string country) : base(name)
    {
        Country = country;
    }

    // Перевизначений метод, що відображає опис пароплава
    public override void Desc()
    {
        Console.WriteLine($"This is a ship from {Country}: {Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів різних типів пристроїв
        Device device1 = new Kettle("Electric Kettle", "Electric");
        Device device2 = new Microwave("Microwave Oven", 1000);
        Device device3 = new Car("SUV", "Toyota");
        Device device4 = new Steamship("Cargo Ship", "USA");

        // Виклик методів для кожного пристрою
        device1.Show();
        device1.Desc();
        device1.Sound();
        Console.WriteLine();

        device2.Show();
        device2.Desc();
        device2.Sound();
        Console.WriteLine();

        device3.Show();
        device3.Desc();
        device3.Sound();
        Console.WriteLine();

        device4.Show();
        device4.Desc();
        device4.Sound();
    }
}
