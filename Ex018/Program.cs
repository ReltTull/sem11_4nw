// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool isequil(int X, int Y)
{
    return ((-(X + Y)) == -X * -Y);
}
System.Console.WriteLine(isequil(1,1));