// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Введите координаты b1 и k1: ");
double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты b2 и k2: ");
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double x = 0;
double y = 0;

y = k1 * x + b1;
y = k2 * x + b2;

/* Берем систему уравнений и получаем k1*x+b1 = k2*x+b2 => k1*x-k2*x = b1-b2 => x = (b2-b1)/(k2-k1). 
Подставляем полученное значение x в уравнение и получаем y = k1*((b2-b1)/(k2-k1))+b1 */

x = (b2-b1)/(k2-k1);
y = k1*((b2-b1)/(k2-k1))+b1;

Console.WriteLine($"Точка пересечения = ({x}) и ({y})");