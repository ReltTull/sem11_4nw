// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] GetSumOfEvenNumb(int size)
{
    int[] RandArr = new int[size];
    int sum = 0;
    for(int i = 0; i < size; i++)
    {
        RandArr[i] = new Random().Next(-10,10);
        System.Console.Write(RandArr[i] + " ");
        if(i%2 != 0)
        {
            sum = sum + RandArr[i];
        }
        else {}
    }
    System.Console.WriteLine();
    System.Console.WriteLine(sum);
    return RandArr;
}
System.Console.WriteLine(GetSumOfEvenNumb(7));