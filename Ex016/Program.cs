// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.WriteLine("Print number (1-7)");
string a = Console.ReadLine();
if (a == "6" | a== "7") // "|" - оператор "или".
{
    System.Console.WriteLine("Weekend number");
}
else {System.Console.WriteLine("not a weekend number");}
