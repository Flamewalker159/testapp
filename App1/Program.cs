using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1. Вывести текущую дату и время");
            Console.WriteLine("2. Вычислить квадрат числа");
            Console.WriteLine("3. Проверить, является ли число четным");
            Console.WriteLine("4. Вывести приветствие");
            Console.WriteLine("0. Очистить консоль и выйти");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        //DisplayCurrentDateTime();
                        break;
                    case 2:
                        //CalculateSquare();
                        break;
                    case 3:
                        //CheckEvenOrOdd();
                        break;
                    case 4:
                        //DisplayGreeting();
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор, попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте снова.");
            }

        } while (choice != 0);
    }

    static void DisplayCurrentDateTime()
    {
        Console.Clear();
        Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
    }
}
