/*
напоишите программу, которая принимает на входе координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5,0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("введите xa");
int xa = int.Parse(Console.ReadLine()); 
Console.WriteLine("введите ya");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("введите za");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("введите xb"); 
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("введите yb");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("введите zb");
int zb = int.Parse(Console.ReadLine());

double Distance (int xaLocal, int yaLocal, int zaLocal, int xbLocal, int ybLocal, int zbLocal) 
{
    double Dis = Math.Sqrt(Math.Pow((xbLocal-xaLocal),2) + Math.Pow((ybLocal - yaLocal),2) + Math.Pow((zbLocal - zaLocal),2));
    return Dis;
}
Console.WriteLine(Distance (xa, ya, za, xb, yb, zb));