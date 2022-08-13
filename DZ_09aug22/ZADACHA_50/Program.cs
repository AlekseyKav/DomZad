// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> числа с такой позицией в массиве нет.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
          }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
 
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
 
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
 
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Введите номер строки элемента: ");
int ro = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца элемента: ");
int cl = int.Parse(Console.ReadLine());

if (ro > array.GetLength(0) || cl > array.GetLength(1))
    Console.Write($"Элемент с такой позицией в массиве отсутствует.");
else
{
    Console.Write($"На заданной позиции находится число - {array[ro-1, cl-1]} ");   
}

