
int N = new Random().Next(12321, 12323);
System.Console.WriteLine(N);
bool IsPolindrome(int N)
{
    string C = Convert.ToString(N);
    int N1 = C[0];
    int N2 = C[1];
    int N3 = C[3];
    int N4 = C[4];
    if (N1 == N4 & N2 == N3)
    {
        return true;
    }
    else
    {
        return false;
    }
}
System.Console.WriteLine(IsPolindrome (N));

// if (IsPolindrome(12312)) Console.WriteLine("Палиндром.");
// else Console.WriteLine("Не палиндром.");


