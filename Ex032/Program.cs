// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int[] a=new int[8];
// Random rnd;
// rnd=new Random();
// for(int i=0;i<8;i++) 
// {
//     a[i]=rnd.Next(0,2);
// }
// for(int i=0;i<8;i++) 
// {
//     Console.Write(a[i]+" ");
// }
int[] ShowArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write(array[i] + " ");
    }
    return array;
}

int[] ActualArray = ShowArray(8);
int[] ExpectedArray = { 0, 1, 0, 1, 1, 0, 1, 0 };

bool TestingArray(int[] array1, int[] array2)
{
    if (array1.Length != array2.Length) return false;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != 0 | array1[i] != 1)
        {
            return false;
        }
    }
    return true;
}

System.Console.WriteLine();
System.Console.WriteLine(ShowArray(8));
System.Console.WriteLine(TestingArray(ActualArray, ExpectedArray));