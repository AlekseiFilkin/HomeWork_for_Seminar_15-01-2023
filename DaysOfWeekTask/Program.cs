//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите число, обозначающее день недели: ");
int Day = int.Parse(Console.ReadLine() ?? "");
if (Day == 6 || Day == 7)
    {
        Console.Write("Это выходной!");
    }
else if (Day >= 1 && Day <= 5)
    {
        Console.Write("Это рабочий день :(");
    }
else if (Day < 1 || Day > 7)
    {
        Console.Write("Таких дней недели нет...");
    }