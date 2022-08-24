// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива, посчитайте произведение их элементов. Например:

// 1 4 7 2        x        1 5 8 5     =       1 20 56 10
// 5 9 2 3        x        4 9 4 2     =       20 81 8 6
// 8 4 2 4        x        7 2 2 6     =       56 8 4 24
// 5 2 6 7        x        2 3 4 7     =       10 6 24 49

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


Console.Write("Введите количество строк и столбцов массивов: ");
int m = int.Parse(Console.ReadLine());
 
int[,] array1 = GetArray(m, m, 0, 10);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(m, m, 0, 10);
PrintArray(array2);

int[,] resArr = new int[m,m];
Console.WriteLine($"\nПроизведение первой и второй матриц: ");
ResArray(array1, array2, resArr);

void ResArray(int[,] array1, int[,] array2, int[,] resArr)
{
  for (int i = 0; i < resArr.GetLength(0); i++)
  {
    for (int j = 0; j < resArr.GetLength(1); j++)
    {
    resArr[i,j] = array1[i,j] * array2[i,j];
    }
  }
}
PrintArray(resArr);