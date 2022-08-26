// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте значение n ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте значение m ");
int m = int.Parse(Console.ReadLine());
if (n < m)
{
    int k = 0;
    k = n; n = m; m = k;  
}


int GetSum(int n1, int m1)
{
    if (n1 == m1) return n1;
    return (GetSum(n1 - 1, m1) + n1);
}

Console.WriteLine(GetSum(n, m));