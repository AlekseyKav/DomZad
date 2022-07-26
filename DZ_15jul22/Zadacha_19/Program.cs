/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int num = 0; num = Convert.ToInt32(Console.ReadLine());

int x5 = num / 10000;
int x1 = num % 10;
int x41 = num / 1000;
int x4 = x41 % 10;
int x2 = num / 10 % 10;

/*for (int i = 0; i <= number ; i++)
if (i % 2 == 0) Console.WriteLine(i);
*/

if (x5 == x1 && x4 == x2) Console.Write("число является палиндромом");
else
{
    Console.Write("число НЕявляется палиндромом");
}
