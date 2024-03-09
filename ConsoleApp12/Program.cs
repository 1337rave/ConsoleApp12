using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Абстрактний базовий клас Worker (працівник)
abstract class Worker
{
    // Абстрактний метод Print()
    public abstract void Print();
}

// Похідний клас President (Президент)
class President : Worker
{
    // Перевизначений метод Print() для президента
    public override void Print()
    {
        Console.WriteLine("President: Responsible for overall management and decision making.");
    }
}

// Похідний клас Security (Охоронець)
class Security : Worker
{
    // Перевизначений метод Print() для охоронця
    public override void Print()
    {
        Console.WriteLine("Security: Responsible for ensuring safety and security measures.");
    }
}

// Похідний клас Manager (Менеджер)
class Manager : Worker
{
    // Перевизначений метод Print() для менеджера
    public override void Print()
    {
        Console.WriteLine("Manager: Responsible for overseeing a specific department or team.");
    }
}

// Похідний клас Engineer (Інженер)
class Engineer : Worker
{
    // Перевизначений метод Print() для інженера
    public override void Print()
    {
        Console.WriteLine("Engineer: Responsible for designing, developing, and maintaining products or systems.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів різних типів працівників
        Worker worker1 = new President();
        Worker worker2 = new Security();
        Worker worker3 = new Manager();
        Worker worker4 = new Engineer();

        // Виклик методів Print() для кожного працівника
        worker1.Print();
        worker2.Print();
        worker3.Print();
        worker4.Print();
    }
}
