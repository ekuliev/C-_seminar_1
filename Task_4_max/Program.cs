// Принимает на вход "n" чисел и выдаёт максимальное из этих чисел
decimal Max = 0, a = 0;
int i = 0, n = 3;
while(i < n)
{
    Console.Write("Введите число:");
    a = Convert.ToDecimal(Console.ReadLine());
    if(a > Max) Max = a;
    i++;
}
Console.Write($"Максимальное число: {Max}");

