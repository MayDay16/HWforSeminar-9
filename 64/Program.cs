/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */
Console.Write("Введите целое число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите целое число N: ");
int N = int.Parse(Console.ReadLine());
if (M < N) Rec(M, N);
else RecInvers(M, N);

void Rec(int M, int N)
{
    if (M > N)
    {
        return;
    }
    Console.Write(M + " ");
    Rec(M + 1, N);
}
void RecInvers(int M, int N)
{
    if (M < N)
    {
        return;
    }
    Console.Write(M + " ");
    RecInvers(M - 1, N);
}
