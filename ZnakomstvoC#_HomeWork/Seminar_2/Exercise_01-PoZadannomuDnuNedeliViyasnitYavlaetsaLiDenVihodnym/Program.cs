// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня недели:");
int nomer = int.Parse(Console.ReadLine());
if(nomer == 1 || nomer == 2 || nomer == 3 || nomer == 4 || nomer == 5) 
{
    Console.WriteLine("Это будний день, попробуйте еще.");
}

else if(nomer == 6 || nomer == 7)
{
    Console.WriteLine("Это выходной!");
} 
else Console.WriteLine("Введите корректный день недели");