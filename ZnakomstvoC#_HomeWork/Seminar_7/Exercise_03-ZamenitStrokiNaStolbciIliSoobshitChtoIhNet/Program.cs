/* Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
+ что это невозможно (в случае, если матрица не квадратная).*/
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
void RowColumnChange(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int tmp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = tmp;
        }
    }
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
int[,] matr = new int[row, column];

FillMatrix(matr);
PrintMatrix(matr);
Console.WriteLine();
if (row == column)
{
    RowColumnChange(matr);
    PrintMatrix(matr);
}
if (row != column)
    Console.WriteLine("Матрица не квадратная!");
Console.WriteLine();





















/*void PrintMatrix(int[,] matrix)
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
void MatrixRowAndColumnChange(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int tmp = matrix[i, j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = tmp;
        }
    }
}
Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
int[,] matr = new int[row, column];

FillMatrix(matr);
PrintMatrix(matr);
Console.WriteLine();
if(row==column)
{
    MatrixRowAndColumnChange(matr);
    PrintMatrix(matr);
}
if(row!=column)
    Console.WriteLine("Матрица не квадратная!");
Console.WriteLine();*/