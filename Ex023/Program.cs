// 23. Показать таблицу квадратов чисел от 1 до N 
// int showsqrtable(int a, int n)
// {
//     while (a < n)
//     {
//         int sa = a * a;
//         a++;
//     }
//     return n;
// }
// System.Console.WriteLine(showsqrtable(1, 10));

// void ShowSqrs(int n)
// {
//     for (int a = 1; a < n; a++)
//     {
//         System.Console.WriteLine($"{a} x {a} = {a * a}");
//     }
// }
// ShowSqrs(10);

int[] GetArrayOfSqrs(int size)
{
    int[] result = new int[size];
    for (int i = 1; i <= size; i++)
    {
        result[i-1] = i * i;
    }
    return result;
}
// PrintArray(GetArrayOfSqrs(8));
// i = 0 == result = 1*1
// i = 1 == result = 2*2
// i = 2 == result = 3*3

bool TestingArrays(int[] array1, int[] array2)
{
    if (array1.Length != array2.Length) return false;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            return false;
        }
    }
    return true;
}
// System.Console.WriteLine(TestingArrays(array1, array2));
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

// if ([1, 4, 9, 16, 25, 36, 49, 64] == GetArrayOfSqrs(8)) ; // При значении 8 в GetArrayOfSqrs возвращается массив [1,4,9,16,25,36,49,64]
int[] array1 = { 1, 2, 3, 4 };
int[] array2 = { 1, 2, 3, 4 };
int[] array3 = { 1, 2, 3, 4, 5 };
if (true == TestingArrays(array1, array2)) System.Console.WriteLine("Корректно");
else System.Console.WriteLine("Тест провален");
if (false == TestingArrays(array1, array3)) System.Console.WriteLine("Корректно");
else System.Console.WriteLine("Тест провален");

int[] ExpectedArray = { 1, 4, 9, 16, 25, 36, 49, 64 };
int[] ActualArray = GetArrayOfSqrs(8);
if (true == TestingArrays(ExpectedArray, ActualArray)) System.Console.WriteLine("Корректно");
else System.Console.WriteLine("Тест провален");