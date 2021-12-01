// 47. Написать программу копирования массива

int[] GetRandArr(int size)
{
    int[] RandArr = new int[size];
    for(int i = 0; i < size; i++)
    {
        RandArr[i] = new Random().Next(1,10);
    }
    return RandArr;
}
int[] GetSimArr(int[] array)
{
    System.Console.WriteLine();
    int[] ResArr = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        ResArr[i] =  array[i];
    }
    return ResArr;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
int[] Array1 = GetRandArr(7);
PrintArray(Array1);
System.Console.WriteLine();
int[] Array2 = GetSimArr(Array1);
PrintArray(Array2);