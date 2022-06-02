// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void SumOfRows(int[,] matrix, int[] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = matrix[i, j] + sum;
        }
        array[i] = sum;
        Console.WriteLine($"Сумма строки {i+1} = {array[i]} ");
    }
}
int RowMinSum(int[] array)
{
    int min = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        min = array[0];
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}
Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
int[,] matr = new int[row, column];
int[] arr = new int[row];
FillMatrix(matr);
PrintMatrix(matr);
SumOfRows(matr, arr);
Console.WriteLine($"Номер строки с минимальной суммой элементов: {RowMinSum(arr) + 1} ");