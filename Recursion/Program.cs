string NumberFor(int a, int b)
{

    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

string NumberRec(int a, int b)
{
    if (a <= b) return $"{a}" + NumberRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumberFor(1, 10));
Console.WriteLine(NumberRec(1, 10));


int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}


int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);

}
Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));

int Power(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{      // return n ==0 ? 1: powerRec(a,n-1)*a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;

}


char[] s = {'а', 'и','с','в'};
int count = s.Length;
int n =1;
for(int i =0; i<count;i++)
{
    Console.WriteLine($"{n++,-5}{s[i]}");
}    

void FindWords(string alphabet, char[] word, int lenght = 0)
{
        if(lenght == word.Length)
        {
            Console.WriteLine($"{n++} {new String(word)}"); return;
        }
        for(int i = 0; i < alphabet.Length;i++)
        {
            word[lenght] = alphabet[i];
            FindWords(alphabet, word, lenght+1);
        }
}

FindWords("аисв", new char[2]);

