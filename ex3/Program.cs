// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int funAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return funAkkerman(m - 1, 1);
  else return funAkkerman(m - 1, funAkkerman(m, n - 1));
}

int PrintNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.Clear();
int m = PrintNumber("Введите m: ");
int n = PrintNumber("Введите n: ");

int functionAkkerman = funAkkerman(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

