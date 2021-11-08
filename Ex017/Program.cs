// 17. По двум заданным числам проверять является ли одно квадратом другого

int a = 5;
int b = 16;
if (a*a == b)
{
    System.Console.WriteLine($"{b} - квадрат числа {a}");
}
else
{
    if (b*b == a)
    {
        System.Console.WriteLine($"{a} - квалрат числа {b}");
    }
    else {System.Console.WriteLine("числа не являются квадратами друг друга");}
}