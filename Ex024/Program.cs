// 24. Найти кубы чисел от 1 до N
// int FindCube(int number, int N)
// {
//     for (number = 1; number < N; number++)
//     {
//         int result = number * number * number;
//         return result;
//     }
//     return N;
// }
// System.Console.WriteLine(FindCube(1,5));

int number = 1;
int N = 5;
for (number = 1; number <= N; number++)
{
    System.Console.Write($"Куб числа {number} - ");
    number = number * number * number;
    System.Console.WriteLine(number);
}