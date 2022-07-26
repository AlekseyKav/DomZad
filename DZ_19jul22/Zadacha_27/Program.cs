/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int getSumNumbs(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int num1 = number % 10;
        number = number / 10;
        sum = sum + num1;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(getSumNumbs(num));