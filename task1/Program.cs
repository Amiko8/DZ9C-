int m = InputInt ("Введите пололожительное число m ");
int n = InputInt("Введите положительное число n  оно должно быть больше числа m ");

if (n < 1)
{
    Console.WriteLine("Ввели не положительное число ");
}

if (m < 1)
{
    Console.WriteLine("Ввели не положительное число ");
}

for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}