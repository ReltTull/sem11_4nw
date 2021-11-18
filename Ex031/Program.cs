// 31. Задать массив из 8 элементов и вывести их на экран 

int[] ShowArray(int ArrLenght)
{
int[] array = new int [ArrLenght];
for (int i = 0; i < ArrLenght; i++)
{
    Console.Write(array[i] + " ");
}
return array;
}
System.Console.WriteLine(ShowArray(8));

int[] ExpectedArray = {0, 0, 0, 0, 0, 0, 0, 0};
int[] ActualArray = ShowArray(8);

if (ActualArray.Length == ExpectedArray.Length) System.Console.WriteLine("Корректно");
else System.Console.WriteLine("Не корректно");