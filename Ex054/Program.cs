// 54. В матрице чисел найти сумму элементов главной диагонали
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
int GetDiagonalSum(int[,] array)
{
    int sum = 0;
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int j = i;
            sum = sum + array[i, j];
        }
    }
    return sum;
}

int[,] array1 = GetArray(4, 4, 1, 10);
PrintArray(array1);
System.Console.Write("Diagonal elements sum: ");
System.Console.WriteLine(GetDiagonalSum(array1));