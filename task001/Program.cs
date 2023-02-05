// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Решение.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
if (number[0] == number[4] && number[1] == number[3])
{
  Console.WriteLine($"Число {number} является палиндромом");
}
else
{
  Console.Write($"Число {(number)} не является палиндромом");
}

//Решение.

int[] array = new int[5];

NumArray(array);
NumbArray(array);

void NumArray(int[] numbers)
{
  int mas = numbers.Length;
  int index = 0;
  while (index < mas)
  {
    Console.WriteLine("Введите каждую цыфру");
    numbers[index] = int.Parse(Console.ReadLine());
    index++;
  }
}

void NumbArray(int[] numbers)
{
  int mas = numbers.Length;
  if (numbers[0] == numbers[4] && numbers[1] == numbers[3])
  {
    Console.WriteLine($"Число {String.Join(",", numbers)} является палиндромом");
  }
  else
  {
    Console.WriteLine($"Число {String.Join(",", numbers)} не является палиндромом");
  }
}

