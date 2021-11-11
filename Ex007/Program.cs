// 7. Показать числа от -N до N
// int ShowNumbers(int n1)
// {
//     int n = n1;
//     int index = -n1;
//     while (index <= -n)
//     {
//         System.Console.WriteLine(index);
//         index++;
//     }
//     return index;
// }
// System.Console.WriteLine(ShowNumbers(-7));

int ShowNumbers(int n1)
{
    int n = n1;
    int index = -n1;
    while (index <= -n)
    {
        System.Console.WriteLine(index);
        index++;
    }
    return index;
}
System.Console.WriteLine(ShowNumbers(-7));


// bool IsPolindrome(int N)
// {
//     string C = Convert.ToString(N);
//     int N1 = C[0];
//     int N2 = C[1];
//     int N3 = C[3];
//     int N4 = C[4];
//     if (N1 == N4 & N2 == N3)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
// bool c = IsPolindrome (21312);
// System.Console.WriteLine(c);




// for(index = n; index < -n; index++)
// int CreateArray(int [] array)
// {
//     int n = n1;
//     int index = n;
//     for(index = n; index < -n; index++)
//     {
//         array[index + " "];
//     }
// }

// int n = -7;
// int index = n;
// while (index <= -n)
// {
//     Console.Write(index + " ");
//     index++;
// }