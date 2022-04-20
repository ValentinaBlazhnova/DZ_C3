/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
distance = корень из: (xA - xB)^2 + (yA - yB)^2 + (zA - zB)^2*/

int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");

int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double sum = Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2);
double distance = Math.Sqrt(sum);
Console.Write($"Расстояние между точками равно {distance}");

