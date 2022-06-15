//  Напишите программу, которая на вход принимает 
// два числа и выдаёт первые N чисел, для которых 
// каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

// решение Александра
// void GetNumRow(int a, int b, int n)
// {
//     if (n==2) return;
//     int outputNum = a + b;
//     Console.Write($"{outputNum} ");
//     a = b;
//     b = outputNum;
//     GetNumRow(a, b, n - 1);
// }

// Console.Write("Введите a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите b: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Введите N чисел, для которых каждое следующее равно сумме двух предыдущих чисел: ");
// int n = int.Parse(Console.ReadLine());
// Console.Write($"{a} {b} ");
// GetNumRow(a, b, n);

// решение преподавателя
Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите N чисел, для которых каждое следующее равно сумме двух предыдущих чисел: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n; i++)
{
    Console.Write(Summa(numFirst, numSecond, i) + " ");
}
Console.WriteLine("\n");
int Summa(int a, int b, int n)
{
    if (n == 1) return a;
    if (n == 2) return b;
    int sum = Summa(a, b, n - 1) + Summa(a, b, n - 2);
    return sum;
}
