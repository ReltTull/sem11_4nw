// 26. Возведите число А в натуральную степень B используя цикл

int DegreeNumberToDegree(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++);
    {
        result = result * number;
    }
    return result;
}
System.Console.WriteLine(DegreeNumberToDegree(2,3));


if (8 == DegreeNumberToDegree(2,3))
{
    System.Console.WriteLine("Correct");
}
else 
{
    System.Console.WriteLine("Uncorrect");
}