// 30. Показать кубы чисел, заканчивающихся на четную цифру

// int CubeOfNumber(int number, int N)
// {
//     while (number < N)
//     {
//         number = number * number * number;
//         number ++;
//     }
//     return number;
// }
// System.Console.WriteLine(CubeOfNumber(1,5));

int number = 1;
int N = 10;
for (number = 1; number <= N; number++)
{
    int result = number * number * number;
    if (result % 2 == 0)
    {
        System.Console.WriteLine(result);
    }
}

