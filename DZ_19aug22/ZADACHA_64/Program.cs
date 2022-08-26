// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Задайте значение n ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте значение m ");
int m = int.Parse(Console.ReadLine());
if (n < m)
{
    int k = 0;
    k = n; n = m; m = k;  
}

string Print(int n1, int m1)
{
    string s = "";
    if (n1 == m1 - 1) return s;
    return (Print(n1 - 1, m1) + n1).ToString();
}

Console.WriteLine(Print(n, m));

