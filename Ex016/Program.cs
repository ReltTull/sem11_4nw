// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

// System.Console.WriteLine("Print number (1-7)");
// string b = Console.ReadLine();
// bool isweekend(string a)
// {
// return (a == "6" | a== "7");
// }
// System.Console.WriteLine(isweekend(b));

// System.Console.WriteLine("Print number (1-7)");
// string a = Console.ReadLine();
// if (a == "6" | a== "7") // "|" - оператор "или".
// {
//     System.Console.WriteLine("Weekend number");
// }
// else {System.Console.WriteLine("not a weekend number");}

System.Console.WriteLine("Print number (1-7)");
string b = Console.ReadLine();
if (b == "6" | b == "7")
{
    System.Console.WriteLine("weekend");
}
if (b != "6" & b != "7")
{
    System.Console.WriteLine("not a weeknd");
}