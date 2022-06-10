// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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
            matrix[i, j] = new Random().Next(0, 5);
        }
    }
}
int[] MinElement(int[,] matrix)
{
    int[] tmp = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                tmp[0] = i;
                tmp[1] = j;
            }
        }
    }
    return tmp;
}
int[,] DelRowAndColumn(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (i >= row && j < column)
                newMatrix[i, j] = matrix[i + 1, j];
            else if (i < row && j >= column)
                newMatrix[i, j] = matrix[i, j + 1];
            else if (i >= row && j >= column)
                newMatrix[i, j] = matrix[i + 1, j + 1];
            else 
                newMatrix[i, j] = matrix[i, j];
        }
    }
    return newMatrix;
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.WriteLine();
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"{MinElement(matrix)[0]},{MinElement(matrix)[1]} ");
Console.WriteLine();
PrintMatrix(DelRowAndColumn(matrix, MinElement(matrix)[0], MinElement(matrix)[1]));