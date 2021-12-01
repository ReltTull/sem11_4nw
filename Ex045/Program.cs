// 45. Показать числа Фибоначчи

// int[] Fib = new int[7];
// Fib[0] = 0;
// Fib[1] = 1;
// System.Console.Write(Fib[0] + " " + Fib[1] + " ");
// for(int i = 2; i < 7; i++)
// {
//     Fib[i] = Fib[i-1] + Fib[i-2];
//     System.Console.Write(Fib[i] + " ");
// }

int[] GetFibNumbrs(int size)
{
    int[] Fib = new int[size];
    Fib[0] = 0;
    Fib[1] = 1;
    Console.Write(Fib[0] + " " + Fib[1] + " ");
    for (int i = 2; i < size; i++)
    {
        Fib[i] = Fib[i - 1] + Fib[i - 2];
        System.Console.Write(Fib[i] + " ");
    }
    return Fib;
}
bool TestFib(int[] arr1, int[] arr2)
{
    if(arr1.Length != arr2.Length) return false;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i] != arr2[i]) return false;
    }
    return true;
}

int[] ExpArr = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34};
int[] CurrentArr = GetFibNumbrs(10);
System.Console.WriteLine();
// System.Console.WriteLine(GetFibNumbrs(10));
if(true == TestFib(ExpArr, CurrentArr)) System.Console.WriteLine("GetFibNumbrs is correct method");
else System.Console.WriteLine("GetFibNumbrs doesn't correct method");