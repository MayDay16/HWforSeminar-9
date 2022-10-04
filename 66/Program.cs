/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

 int sum = 0;
 Console.Write("Введите натуральное целое число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное целое число N: ");
int N = int.Parse(Console.ReadLine());
RecSum(M, N);
Console.WriteLine(sum);
void RecSum(int M, int N)
{
    if (M > N)
    {
        return;
    }
    sum += M;
    RecSum(M + 1, N);
}
