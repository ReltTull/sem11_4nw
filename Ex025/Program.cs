// 25. Найти сумму чисел от 1 до А
// int A = 10;
// int sum = 0;
// for (int number = 1; number < A; number++)
// {
//     sum = sum + number;
// }
// System.Console.WriteLine(sum);

int FindSum(int A)
{
    int sum = 0;
    for (int number = 1; number < A; number++)
    {
        sum = sum + number;
    }
    return sum;
}
System.Console.WriteLine(FindSum(7));
