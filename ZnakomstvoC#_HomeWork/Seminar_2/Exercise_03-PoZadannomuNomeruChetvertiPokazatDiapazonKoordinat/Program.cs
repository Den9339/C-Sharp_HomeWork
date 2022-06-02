// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine());
if(a == 1) Console.WriteLine("Диапазон координат для четверти 1: x > 0,  y > 0");
else if(a == 2) Console.WriteLine("Диапазон координат для четверти 2: x < 0,  y > 0");
else if(a == 3) Console.WriteLine("Диапазон координат для четверти 3: x < 0,  y < 0");
else if(a == 4) Console.WriteLine("Диапазон координат для четверти 4: x > 0,  y < 0");
else Console.WriteLine("Введите верный номер четверти");
