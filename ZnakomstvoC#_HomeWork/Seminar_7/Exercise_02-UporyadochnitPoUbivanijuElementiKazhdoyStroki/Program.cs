// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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
void StreamlineElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, j])
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = tmp;
                }
            }
        }
    }
}

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
int[,] matr = new int[row, column];
FillMatrix(matr);
PrintMatrix(matr);
Console.WriteLine();
StreamlineElements(matr);
PrintMatrix(matr);



















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
void SwitchMatrixElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if  (matrix[i, k] > matrix[i, j])
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = tmp;
                }

            }
        }

    }
}
Console.Clear();
Console.WriteLine("Введите размер массива: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SwitchMatrixElements(matrix);
PrintMatrix(matrix);*/

