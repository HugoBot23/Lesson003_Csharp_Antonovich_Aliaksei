// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Решение.

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 1;

while (count <= number)
{
  Console.Write(Math.Pow(count, 3));
  Console.Write(", ");
  count++;
}

//Решение.

Console.WriteLine("Втрое решение задачи");
Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
int count1 = 1;

while (count1 <= number1)
{
  int summa1 = count1 * count1 * count1;
  Console.Write($"{summa1}, ");
  count1++;
}
