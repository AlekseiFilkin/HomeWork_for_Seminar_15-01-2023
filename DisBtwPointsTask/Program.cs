//Найти расстояние между точками в пространстве 2D
Console.Write("Введите координату x точки А: ");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите координату y точки А: ");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите координату x точки B: ");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите координату y точки B: ");
int y2 = int.Parse(Console.ReadLine() ?? "");
double quad1 = Math.Pow((x2 - x1), 2);
double quad2 = Math.Pow((y2 - y1), 2);
double sum = quad1 + quad2;
double dist = Math.Sqrt(sum);
Console.WriteLine("Расстояние между точками А и В равно: " + dist);

//Найти расстояние между точками в пространстве 3D
//Console.Write("Введите координату x точки А: ");
//int x1 = int.Parse(Console.ReadLine() ?? "");
//Console.Write("Введите координату y точки А: ");
//int y1 = int.Parse(Console.ReadLine() ?? "");
//Console.Write("Введите координату z точки А: ");
//int z1 = int.Parse(Console.ReadLine() ?? "");
//Console.Write("Введите координату x точки B: ");
//int x2 = int.Parse(Console.ReadLine() ?? "");
//Console.Write("Введите координату y точки B: ");
//int y2 = int.Parse(Console.ReadLine() ?? "");
//Console.Write("Введите координату z точки B: ");
//int z2 = int.Parse(Console.ReadLine() ?? "");
//double quad1 = Math.Pow((x2 - x1), 2);
//double quad2 = Math.Pow((y2 - y1), 2);
//double quad3 = Math.Pow((z2 - z1), 2);
//double sum = quad1 + quad2 + quad3;
//double dist = Math.Sqrt(sum);
//Console.WriteLine("Расстояние между точками А и В равно: " + dist);