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
                        DisplayCurrentDateTime();
                        break;
                    case 2:
                        CalculateSquare();
                        break;
                    case 3:
                        CheckEvenOrOdd();
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

    static void CalculateSquare()
    {
        Console.Clear();
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine($"Квадрат числа {number} равен {number * number}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод числа.");
        }
    }

    static void CheckEvenOrOdd()
    {
        Console.Clear();
<<<<<<< HEAD
        Console.WriteLine("Введите число: ");
=======
        Console.Write("Введите число: ");
>>>>>>> 56cbb563a646b9fc092bad9b5b1300ceb7ddbe30
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} - четное число.");
            }
            else
            {
                Console.WriteLine($"{number} - нечетное число.");
            }
        }
        else
        {
<<<<<<< HEAD
            Console.WriteLine("Вы ввели неккоректно число.");
=======
            Console.WriteLine("Некорректный ввод числа.");
>>>>>>> 56cbb563a646b9fc092bad9b5b1300ceb7ddbe30
        }
    }
}
