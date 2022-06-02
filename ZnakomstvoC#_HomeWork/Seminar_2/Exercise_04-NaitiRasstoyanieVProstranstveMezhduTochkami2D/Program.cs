// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите координаты x и y точки 1: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x и y точки 2: ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int r = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
Console.WriteLine(Math. Sqrt(r));