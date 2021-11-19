// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] NonIntArr = new double[7];
for (int i = 0; i < 7; i++)
{
    NonIntArr[i] = new Random().NextDouble() * 10;
    System.Console.Write(NonIntArr[i] + " ");
}
double min = NonIntArr[0];
for (int i = 1; i < 7; i++)
{
    if (NonIntArr[i] < min)
    {
        min = NonIntArr[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine($" minimum value is - {min}");
double max = NonIntArr[0];
for (int i = 1; i < 7; i++)
{
    if (NonIntArr[i] > max)
    {
        max = NonIntArr[i];
    }
}
System.Console.WriteLine($" maximum value is - {max}");
double dif = max - min;
System.Console.WriteLine($"  difference between values maximum and minimum is - {dif}");