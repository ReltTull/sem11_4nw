// 17. По двум заданным числам проверять является ли одно квадратом другого

// bool issqr(int a, int b)
// {
//     return (a*a == b) & (b*b == a);
// }
// System.Console.WriteLine(issqr(4,2));


// int a = 4;
// int b = 2;
// if (a*a == b)
// {
//     System.Console.WriteLine($"{b} - квадрат числа {a}");
// }
// else
// {
//     if (b*b == a)
//     {
//         System.Console.WriteLine($"{a} - квалрат числа {b}");
//     }
//     else {System.Console.WriteLine("числа не являются квадратами друг друга");}
// }

int issqr(int a, int b, string text)
{
if (a*a == b)
{
    text = $"{b} - квадрат числа {a}";
    return text;
}
else
{
    if (b*b == a)
    {
        text = $"{a} - квалрат числа {b}";
        return text;
    }
    else {System.Console.WriteLine("числа не являются квадратами друг друга");}
}
return text;
}
System.Console.WriteLine(issqr(4,16));