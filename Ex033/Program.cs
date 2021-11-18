// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных 
//элементов массива

// int[] ShowArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-9, 9);
//         Console.Write(array[i] + " ");
//     }
//     return array;
// }
// System.Console.WriteLine(ShowArray(12));


// int[] array = new int[12];
// for (int i = 0; i < 12; i++)
// {
//     array[i] = new Random().Next(-9, 9);
//     Console.Write(array[i] + " ");
// }
// int sumpos = 0;
// int sumneg = 0;
// for (int i = 0; i < 12; i++)
// {
//     if (array[i] > 0)
//     {
//         sumpos = sumpos + array[i];
//     }
//     else
//     {
//         sumneg = sumneg + array[i];
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine(sumpos);
// System.Console.WriteLine(sumneg);

int[] PrintArrayWPN(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 9);
        Console.Write(array[i] + " ");
    }
    int sumpos = 0;
    int sumneg = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0)
        {
            sumpos = sumpos + array[i];
        }
        else { sumneg = sumneg + array[i]; }
    }
    System.Console.WriteLine();
    System.Console.WriteLine(sumpos);
    System.Console.WriteLine(sumneg);
    return array;
}
System.Console.WriteLine(PrintArrayWPN(12));