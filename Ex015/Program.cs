// 15. Дано число. Проверить кратно ли оно 7 и 23 

bool ismultiplicity(int a)
{
    return (a % 7 == 0 & a % 23 ==0);
}
System.Console.WriteLine(ismultiplicity(161));

// int a = 161;
// if (a % 7 == 0 & a % 23 ==0)
// {
//     System.Console.WriteLine("yes");
// }
// else {System.Console.WriteLine("no");}