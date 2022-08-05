//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = GetArray(10, -10 , 10);
int sum = 0;
int[] GetArray(int size, int min, int max)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }
  return result;
}
foreach (int i in array)

Console.Write(i + " ");

for (int i = 0; i < array.Length; i++)
{
      sum += (i % 2 != 0) ? array[i] : 0;
}


Console.WriteLine();
Console.Write("Сумма элементов стоящих на не четных позициях = " + sum);