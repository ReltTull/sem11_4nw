// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//     Показать количество нечетныхчетных чисел

int[] GetRandomArr(int size)
{
    int[] RandomArr = new int[size];
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        RandomArr[i] = new Random().Next(100, 1000);
        System.Console.Write(RandomArr[i] + " ");
        if(RandomArr[i] % 2 != 0)
        {
            count = count + 1;
        }
        else {};
    }
    System.Console.WriteLine();
    System.Console.WriteLine(count);
    return RandomArr;
}



System.Console.WriteLine(GetRandomArr(7));