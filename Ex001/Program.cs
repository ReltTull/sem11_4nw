//  1. По двум введённым числам проверять является ли первое квадратом второго

bool issqr(int a, int b)
{
    return (b * b == a);
}
System.Console.WriteLine(issqr(4,2));