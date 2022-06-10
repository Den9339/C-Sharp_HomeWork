// Найти произведение двух матриц
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
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixFinal = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++) //Обратить внимание)
            {
                matrixFinal[i, j] = matrixFinal[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixFinal;
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix_1 = new int[m, n];
int[,] matrix_2 = new int[n, m];
Console.WriteLine();
FillMatrix(matrix_1);
PrintMatrix(matrix_1);
Console.WriteLine();
FillMatrix(matrix_2);
PrintMatrix(matrix_2);
Console.WriteLine();
PrintMatrix(MultiplicationMatrix(matrix_1,matrix_2));




