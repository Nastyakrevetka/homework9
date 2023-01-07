//Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void PrintString(int n, int count)
{
  if (count > n) return;
  PrintString(n, count + 1);
  Console.Write(count + "; ");
}

int PrintNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.Clear();
int n = PrintNumber("Введите n: ");
int count = 2;
PrintString(n, count);
Console.Write(1);


