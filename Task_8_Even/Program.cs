// на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
int i = 1;
Console.Write("Введите число:");
int? N = int.Parse(Console.ReadLine());
while (i <= N)
{
    if (i% 2 == 0) Console.Write($"{i} ");
    i++;
}