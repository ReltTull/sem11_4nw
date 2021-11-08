// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a = new Random().Next(10, 100);
System.Console.WriteLine(a);
System.Console.WriteLine();
int b = a % 10;
int c = a / 10;
if (b > c)
{
    System.Console.WriteLine("max = " + b);
}
else
{
    System.Console.WriteLine("max = " + c);
}

// int CreateNum()
// {
//     int ranNum = new Random().Next(10, 100);
//     return ranNum;
// }

// int number = CreateNum();
// Console.WriteLine(number);