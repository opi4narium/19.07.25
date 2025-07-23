using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Введите ваш рост в метрах: ");
        double height = double.Parse(Console.ReadLine());

        Console.Write("Введите ваш пол (М/Ж): ");
        string genderInput = Console.ReadLine();
        string gender = genderInput.ToUpper() == "М" ? "Мужской" : "Женский";

        Console.Write("Введите вашу любимую букву: ");
        char favoriteLetter = char.Parse(Console.ReadLine());

        Console.Write("Введите ваш город проживания: ");
        string city = Console.ReadLine();

        Console.WriteLine("\n------ АНКЕТА ПОЛЬЗОВАТЕЛЯ ------");
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("Рост: " + height + " м");
        Console.WriteLine("Пол: " + gender);
        Console.WriteLine("Любимая буква: " + favoriteLetter);
        Console.WriteLine("Город: " + city);
    }
}