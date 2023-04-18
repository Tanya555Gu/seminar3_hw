// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string messege)
{
    Console.Write($"{messege} >");
    return Convert.ToInt32(Console.ReadLine());
}


int ax = ReadInt("Введите координату X первой точки");
int ay = ReadInt("Введите координату Y первой точки");
int az = ReadInt("Введите координату Z первой точки");
int bx = ReadInt("Введите координату X второй точки");
int by = ReadInt("Введите координату Y второй точки");
int bz = ReadInt("Введите координату Z второй точки");


int koordX = (ax - bx);
int koordY = (ay - by);
int koordZ = (az - bz);
double W = Math.Sqrt(Math.Pow(koordX, 2) + Math.Pow(koordY, 2) + Math.Pow(koordZ, 2));
Console.Write($"Расстояние между двумя точками равно {W:f2}");