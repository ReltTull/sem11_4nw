//  1. По двум введённым числам проверять является ли первое квадратом второго

int a = 9;
int b = 3;
if (b * b == a)
{
    Console.WriteLine(b + " is the root of the number " + a);
}
else
{
    Console.WriteLine(b + " isn't the root of the number " + a);
}