// int RandomNum()
// {
//     int x = new Random().Next(1, 1000);
//     return x;
// }

// int number = RandomNum();
// System.Console.WriteLine(number);
// // void FindThirdNum(int arg)
// // {
// //     if((number / 100) >= 1)
// //     {
// //         int y = number % 10;
// //         Console.WriteLine($"Третьей цифрой числа {number} является {y}");
// //     }
// //     else
// //     {
// //         Console.WriteLine("Третьей цифры в числе нет!");
// //     }
// // }
// // FindThirdNum(number);

// void Numbers(int N)
// {
//     for (int i = 2; i < N; i++)
//     {
//         System.Console.Write(i + " ");
//     }
// }
// int N = 20;
// Numbers(N);

// 14. Найти третью цифру числа или сообщить, что её нет
int a = new Random().Next(1, 10);
System.Console.WriteLine(a);
void Number(int a)
{
    // if (a < 100) 
    if (a / 100 == 0)
    {
        Console.WriteLine("third number doesn't exist");
    }
    if (a > 100 & a < 1000)
    {
        int b = a / 100;
        System.Console.WriteLine(b);
    }
    if (a > 1000)
    {
        int b = a / 100;
        int c = b % 10;
        System.Console.WriteLine(c);
    }
}
Number(a);