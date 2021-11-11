// 2. Даны два числа. Показать большее и меньшее число
int G = new Random().Next(10, 100);
System.Console.WriteLine(G);
char GetMaxNumber(int G)
{
    string ab = Convert.ToString(G);
    char G1 = ab[0];
    char G2 = ab[1];
    if (G1 > G2) {return G1;}
    else {return G2;}
}
char M = GetMaxNumber(G);
Console.WriteLine($"В числе {G} наибольшая цифра - {GetMaxNumber(G)}");

// char - ?