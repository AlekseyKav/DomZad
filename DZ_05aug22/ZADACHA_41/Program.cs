// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Вам необходимо ввести произвольные, целые, положительные и/или отрицательные числа.\nКакое колличество чисел будем исследовать?\t");
int sum = 0;
int ElemCount = int.Parse(Console.ReadLine());
int [] ar = new int[ElemCount];
for (int i = 0; i < ElemCount; i++)
{
    Console.Write($"Введите число № {i + 1} -\t");
    ar[i] = int.Parse(Console.ReadLine());
}
Console.Write("Из введнных Вами чисел ( ");
foreach (int i in ar)
Console.Write(i + ", ");

for (int i = 0; i < ar.Length; i++)
{
      if (ar[i] > 0)
      {
        sum ++;
      }
}

Console.WriteLine(") - положительными являются - " + sum + "  числа");