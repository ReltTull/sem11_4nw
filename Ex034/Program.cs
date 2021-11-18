// 34. Написать программу замену элементов массива на противоположные

int[] GetReversArr(int size)
{
    int[] RandArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandArray[i] = new Random().Next(1, 10);
        System.Console.Write(RandArray[i] + " ");
    }
    return RandArray;
}
int[] ReversArr(int[] array)
{
    System.Console.WriteLine();
    int[] RevArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        RevArr[i] = -array[i];
        System.Console.Write(RevArr[i] + " ");
    }
    return RevArr;
}
System.Console.WriteLine(ReversArr(GetReversArr(5)));