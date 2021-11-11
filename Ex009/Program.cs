// Показать последнюю цифру трёхзначного числа
int Findunits (int r1)
{
int a = r1;
int units = a % 10;
return units;
}
System.Console.WriteLine(Findunits(421));

