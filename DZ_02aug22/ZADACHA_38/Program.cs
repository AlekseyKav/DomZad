//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

int n = 10;
double[] a = new double[n];
Random random = new Random();
for (int i = 0; i < n; i++)
    {
    a[i] = random.NextDouble() * 10; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    Console.Write("{0,6:F2}", a[i]);
    }
Console.WriteLine();

double min = a[0];
double max = a[0];
for (int i = 1; i < a.Length; i++)
{
      if (a[i] < min)
  {
        min = a[i];
  }
      if (a[i] > max)
  {
        max = a[i];
  }
}

Console.WriteLine();
Console.WriteLine("Разница между максимальны и минимальным значением - {0,6:F2}", (max - min));