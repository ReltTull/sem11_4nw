// 43. Написать программу преобразования десятичного числа в двоичное

// int number = 334;
// int d10 = 1;
// int result = 0;
// while (number != 0)
// {
//     result = result + number % 2 * d10;
//     number= number /2;
//     d10 = d10 * 10;
// }
// System.Console.WriteLine(result);

int number = 251; 
int clss = 1;
int result = 0;
while (number > 2)
{
    result = number % 2 * clss;
}