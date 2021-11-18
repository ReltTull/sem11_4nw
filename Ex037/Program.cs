// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// int[] array = new int[123];
// int count = 0;
// for (int i = 0; i < 123; i++)
// {
//     array[i] = new Random().Next(1, 400);
// if (array[i] >= 10 & array[i] <= 99)
//     {
//         count = count + 1;
//     }
// }
// // System.Console.WriteLine();
// // System.Console.WriteLine(count);


int GetCount(int[] array, int LeftBound, int RightBound)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= LeftBound && array[i] <= RightBound)
        {
            count = count + 1;
        }
    }
    return count;
}
System.Console.WriteLine(GetCount(new int[]{1,18,137,53,67}, 0, 20));

