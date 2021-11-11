// 20. Задать номер четверти, показать диапазоны для возможных координат
System.Console.Write("Введите номер четверти: ");
int q = int.Parse(Console.ReadLine());
if (q == 1)
{
    System.Console.WriteLine("x > 0, y > 0");
}
if (q == 2)
{
    System.Console.WriteLine("x > 0, y < 0");
}
if (q == 3)
{
    System.Console.WriteLine("x < 0, y < 0");
}
if (q == 4)
{
    System.Console.WriteLine("x < 0, y > 0");
}