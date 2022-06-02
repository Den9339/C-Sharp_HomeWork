// Задать двумерный массив следующим правилом: Aₘₙ = m+n
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
            arr[i,j] = i+j;
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