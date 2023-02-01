//По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "");
if (num1 == num2 * num2)
    {
        Console.Write($"Число {num1} является квадратом числа {num2}");
    }
    else if (num2 == num1 * num1)
        {
            Console.Write($"Число {num2} является квадратом числа {num1}");
        }
            else if (num1 != num2 * num2 && num2 != num1 * num1)
                {
                    Console.Write("Числа не являются квадратами друг друга");
                }