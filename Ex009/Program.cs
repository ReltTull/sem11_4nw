// Показать последнюю цифру трёхзначного числа
int a = 234;
int tens = a % 100;
int units = tens % 10;
Console.WriteLine(units);
