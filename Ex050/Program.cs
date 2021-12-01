// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}
int[,] GetSqrOfOddElem(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    array[i, j] = array[i, j] * array[i, j];
                }
            }
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
int[,] array = GetArray(4, 6);
PrintArray(array);
Console.WriteLine();
PrintArray(GetSqrOfOddElem(array));