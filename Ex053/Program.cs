// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
System.Console.Write("Enter the numbers: ");
String numb = Console.ReadLine();
int EntrNumb = Int32.Parse(numb);
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
int[] GetNumbPos(int[,] array, int numb)
{
    int[] NumbPosArr = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(numb == array[i,j]);
            i = NumbPosArr[0];
            j = NumbPosArr[1];
        }
    }
    return NumbPosArr;
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
void PrintOneArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
PrintArray(array);
System.Console.WriteLine();
PrintOneArray(GetNumbPos(array, EntrNumb));


