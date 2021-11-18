// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д.

// int[] InitialArray = { 1, 5, 2, 7, 9, 3, 6, 8 };
// for (int s = 0; s < InitialArray.Length / 2; s++)
// {
//     int sum = InitialArray[0 + s] + InitialArray[InitialArray.Length - 1 - s];
//     Console.WriteLine(sum);
// }

int[] GetRandArr(int size)
{
    int[] RandArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandArray[i] = new Random().Next(1, 10);
        System.Console.Write(RandArray[i] + " ");
    }
    return RandArray;
}

int GetSumOfArrElem(int[] array)
{
    for (int s = 0; s < array.Length / 2; s++)
    {
        int sum = array[0 + s] + array[array.Length - 1 - s];
        System.Console.WriteLine(sum);
    }
    return -1;
}
System.Console.WriteLine(GetSumOfArrElem(GetRandArr(8)));
System.Console.WriteLine(GetRandArr(8));