// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.


int a = new Random ().Next(10,20);
int b = 2;
System.Console.WriteLine(a);
System.Console.WriteLine(b);
if (a % b ==0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Остаток = " + a % b);
}
