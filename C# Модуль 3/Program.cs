using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Введите имя: ");
        var name = Console.ReadLine();

        Console.WriteLine("введите возраст: ");
        var age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя {0}, возвраст {1} лет", name, age);

        Console.WriteLine("введите дату рождения: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Ваше день рождения {0}", birthdate);
    }
}
