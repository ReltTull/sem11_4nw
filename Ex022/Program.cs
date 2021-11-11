// 22. Найти расстояние между точками в пространстве 2D/3D
// double GetLengthBetween(double x1, double y1, double z1, double x2, double y2, double z2) // 22
// {
//     double x = Math.Abs(x1 - x2);
//     double y = Math.Abs(y1 - y2);
//     double z = Math.Abs(z1 - z2);
//     double L = Math.Sqrt(x * x + y * y + z * z);
//     return L; // завершение выполнения метода, возврат в место вызова метода
// }

// double L = GetLengthBetween(0, 0, 0, 1, 2, 2);
// Console.WriteLine(L);

double GetLengthBetween(double x1,double y1,double x2,double y2)
{
    double x = Math.Abs(x1 - x2);
    double y = Math.Abs(y1 - y2);
    double L = Math.Sqrt(x*x + y*y);
    return L;
}
System.Console.WriteLine(GetLengthBetween(1.2,2.6,3.1,4.7));