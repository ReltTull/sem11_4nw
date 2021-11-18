// 35. Определить, присутствует ли в заданном массиве, некоторое число 
int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(1, 6);
    Console.Write(array[i] + " ");
}
System.Console.WriteLine();
int find = 3;
int count = 0;
for (int i = 0; i < 10; i++)
{
    if (find == array[i])
    {
        count = count + 1;
    }
    else {}
}
System.Console.WriteLine($"{find} is using in array {count} times");
