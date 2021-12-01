// Найти произведение побочной диагонали матрицы
int[,] GetArray(int a, int b, int LeftBound, int RightBound)
{
    int[,] array = new int[a, b];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(LeftBound, RightBound);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int GetSideDiagonalElementsMultiplication(int[,] array)
{
    int multiplic = 1;
    {
        for (int c = 0; c < array.GetLength(0); c++)
        {
            {
                multiplic = multiplic * array[c, array.GetLength(0) - 1 - c];
            }
        }
    }
    return multiplic;
}

int[,] array1 = GetArray(5, 5, 1, 10);
PrintArray(array1);
System.Console.Write("Side diagonal elements multiplication: ");
System.Console.WriteLine(GetSideDiagonalElementsMultiplication(array1));