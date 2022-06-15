//  Напишите программу, которая на вход принимает 
// два числа и выдаёт первые N чисел, для которых 
// каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите N чисел, для которых каждое следующее равно сумме двух предыдущих чисел: ");
int n = int.Parse(Console.ReadLine());
if (b < a)
{
    int temp = b;
    b = a;
    a = temp;
}

void PrintSumNumInt(int a, int b, int n)
{
    if (n == 0) return;
    Console.Write($"{a}, ");
    int temp = b;
    b = a+ b;
    a = temp;
    n --;
    PrintSumNumInt(a, b, n);
    return;
}
PrintSumNumInt(a, b, n);
Console.WriteLine();
