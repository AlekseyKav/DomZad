// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


Console.WriteLine($"Введите размер стороны квадратного массива:");
int l = int.Parse(Console.ReadLine());
int[,] arraySpir = new int[l, l];
FillArraySpir(arraySpir, l, l);
Console.WriteLine();
PrintArray(arraySpir);

int[,] FillArraySpir(int[,] array, int row, int col)
{
    int counter = 1, i = 0, j = 0;
    while (counter <= row * col)
    {
        array[i, j] = counter;
        counter++;
        if (i <= j + 1 && i + j < col - 1)
        {
            j++;
        }
        else if (i < j && i + j >= row - 1)
        {
            i++;
        }
        else if (i >= j && i + j > col - 1)
        {
            j--;
        }
        else
        {
            i--;
        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}