// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
//-------------------------------------------------------+
void PrintArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
//-------------------------------------------------------+
void FillArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,10);
        }
    }
}
//-------------------------------------------------------+
void ElementChange(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            
            if(i % 2==0 && j % 2==0)
            {
                arr[i,j] = arr[i,j]*arr[i,j];
            }
        }
    }
}
//-------------------------------------------------------+
Console.WriteLine("Введите размер массива m и n: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m,n]; 
FillArray(array);
PrintArray(array);
ElementChange(array);
Console.WriteLine();
PrintArray(array);
