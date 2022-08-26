// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Задайте первое неотрицательное число n ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте второе неотрицательное число m ");
int m = int.Parse(Console.ReadLine());

static int Ackker(int n1, int m1)
        {
            if (n1 == 0)
            {
                return m1 + 1;
            }
            else if (m1 == 0)
            {
                return Ackker(n1 - 1, 1);
            }
            else
            {
                return Ackker(n1 - 1, Ackker(n1, m1 - 1));
            }
 
        }

Console.WriteLine(Ackker(m, n));