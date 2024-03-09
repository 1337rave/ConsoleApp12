using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Базовий клас MusicalInstrument (Музичний інструмент)
class MusicalInstrument
{
    public string Name { get; set; }

    // Конструктор з параметром для встановлення назви музичного інструменту
    public MusicalInstrument(string name)
    {
        Name = name;
    }

    // Метод, що відтворює звук музичного інструменту
    public virtual void Sound()
    {
        Console.WriteLine($"*Silent*"); // Звук за замовчуванням
    }

    // Метод, що відображає назву музичного інструменту
    public void Show()
    {
        Console.WriteLine($"Musical Instrument: {Name}");
    }

    // Метод, що відображає опис музичного інструменту (загальний опис)
    public virtual void Desc()
    {
        Console.WriteLine($"This is a general musical instrument: {Name}");
    }

    // Метод, що відображає історію створення музичного інструменту
    public virtual void History()
    {
        Console.WriteLine($"The history of {Name}: Not available");
    }
}

// Підклас Violin (Скрипка), успадковує клас MusicalInstrument
class Violin : MusicalInstrument
{
    // Конструктор з параметром для встановлення назви скрипки
    public Violin(string name) : base(name)
    {
    }

    // Перевизначений метод, що відображає опис скрипки
    public override void Desc()
    {
        Console.WriteLine($"This is a violin: {Name}");
    }

    // Перевизначений метод, що відображає історію створення скрипки
    public override void History()
    {
        Console.WriteLine($"The history of {Name}: It dates back to the 16th century.");
    }
}

// Підклас Trombone (Тромбон), успадковує клас MusicalInstrument
class Trombone : MusicalInstrument
{
    // Конструктор з параметром для встановлення назви тромбона
    public Trombone(string name) : base(name)
    {
    }

    // Перевизначений метод, що відображає опис тромбона
    public override void Desc()
    {
        Console.WriteLine($"This is a trombone: {Name}");
    }

    // Перевизначений метод, що відображає історію створення тромбона
    public override void History()
    {
        Console.WriteLine($"The history of {Name}: It was developed in the 15th century.");
    }
}

// Підклас Ukulele (Укулеле), успадковує клас MusicalInstrument
class Ukulele : MusicalInstrument
{
    // Конструктор з параметром для встановлення назви укулеле
    public Ukulele(string name) : base(name)
    {
    }

    // Перевизначений метод, що відображає опис укулеле
    public override void Desc()
    {
        Console.WriteLine($"This is an ukulele: {Name}");
    }

    // Перевизначений метод, що відображає історію створення укулеле
    public override void History()
    {
        Console.WriteLine($"The history of {Name}: It originated in the 19th century in Hawaii.");
    }
}

// Підклас Cello (Віолончель), успадковує клас MusicalInstrument
class Cello : MusicalInstrument
{
    // Конструктор з параметром для встановлення назви віолончелі
    public Cello(string name) : base(name)
    {
    }

    // Перевизначений метод, що відображає опис віолончелі
    public override void Desc()
    {
        Console.WriteLine($"This is a cello: {Name}");
    }

    // Перевизначений метод, що відображає історію створення віолончелі
    public override void History()
    {
        Console.WriteLine($"The history of {Name}: It has roots dating back to the 16th century.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів різних типів музичних інструментів
        MusicalInstrument instrument1 = new Violin("Stradivarius");
        MusicalInstrument instrument2 = new Trombone("King 3B");
        MusicalInstrument instrument3 = new Ukulele("Kamaka");
        MusicalInstrument instrument4 = new Cello("Montagnana");

        // Виклик методів для кожного музичного інструменту
        instrument1.Show();
        instrument1.Desc();
        instrument1.History();
        instrument1.Sound();
        Console.WriteLine();

        instrument2.Show();
        instrument2.Desc();
        instrument2.History();
        instrument2.Sound();
        Console.WriteLine();

        instrument3.Show();
        instrument3.Desc();
        instrument3.History();
        instrument3.Sound();
        Console.WriteLine();

        instrument4.Show();
        instrument4.Desc();
        instrument4.History();
        instrument4.Sound();
    }
}
