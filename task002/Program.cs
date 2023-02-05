// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение.

Console.Clear();
Console.WriteLine("Введите кординату Х для первой точки");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Y для первой точки");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Z для первой точки");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Х для второй точки");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Y для второй точки");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Z для второй точки");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine($"X ({x2}) ({x1}) -> Y ({y2}) ({y1}) -> Z ({z2}) ({z1}) -> {result}");

//Решение.

Console.WriteLine("Втрое решение задачи");
Console.WriteLine("Введите кординату Х для первой точки");
int x_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Y для первой точки");
int y_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Z для первой точки");
int z_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Х для второй точки");
int x_2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Y для второй точки");
int y_2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кординату Z для второй точки");
int z_2 = int.Parse(Console.ReadLine());

double result1 = (x_2 - x_1) * (x_2 - x_1);
double result2 = (y_2 - y_1) * (y_2 - y_1);
double result3 = (z_2 - z_1) * (z_2 - z_1);
double result4 = Math.Sqrt(result1 + result2 + result3);

Console.WriteLine($"X ({x_2}) ({x_1}) -> Y ({y_2}) ({y_1}) -> Z ({z_2}) ({z_1}) -> {result4}");