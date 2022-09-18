// На вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a, b, Max;
Console.WriteLine("Введите число");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
b = int.Parse(Console.ReadLine());
if(a >= b)
{
    Max = a;
}
else
{
    Max = b;
}
Console.Write("max = ");
Console.Write(Max);