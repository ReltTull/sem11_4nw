// 56. Написать программу, которая обменивает элементы первой строки и последней строки
int[,] GetArray(int a, int b, int LeftBound, int RightBound)
{
    int[,] maxtrix = new int[a, b];
    Random random = new Random();
    for (int columns = 0; columns < maxtrix.GetLength(0); columns++)
    {
        for (int rows = 0; rows < maxtrix.GetLength(1); rows++)
        {
            maxtrix[columns, rows] = random.Next(LeftBound, RightBound);
        }
    }
    return maxtrix;
}
void PrintArray(int[,] matrix)
{
    for (int columns = 0; columns < matrix.GetLength(0); columns++)
    {
        for (int rows = 0; rows < matrix.GetLength(1); rows++)
        {
            System.Console.Write($"{matrix[columns, rows]} ");
        }
        System.Console.WriteLine();
    }
}
void GetChangeFirstAndLastRows(int[,] matrix)
{
    for (int rows = 0, columns = 0; rows < matrix.GetLength(1); rows++)
    {
        int tmp = matrix[columns, rows];
        matrix[columns, rows] = matrix[matrix.GetLength(0) - 1, rows];
        matrix[matrix.GetLength(0) - 1, rows] = tmp;
    }
}
int[,] matrix = GetArray(4, 5, 10, 30);
PrintArray(matrix);
Console.WriteLine();
GetChangeFirstAndLastRows(matrix);
PrintArray(matrix);