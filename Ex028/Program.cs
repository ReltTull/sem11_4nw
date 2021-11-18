// // 28. Подсчитать сумму цифр в числе
// int full = 123;
// int sum = 0;
// while (full > 0)
// {
//     sum = sum + full%10;
//     full = full/10;
// }
// System.Console.WriteLine(sum);

int SumOfNumbers(int full)
{
    int sum = 0;
    while (full > 0)
    {
        sum = sum + full%10;
        full = full/10;
    }
    return sum;
}
System.Console.WriteLine(SumOfNumbers(123));

if (7 == SumOfNumbers(123)) System.Console.WriteLine("Корректно");
else System.Console.WriteLine("Не корректно");