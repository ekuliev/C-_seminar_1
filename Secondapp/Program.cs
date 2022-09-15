// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите квадрат числа");
int S = Convert.ToInt32(Console.ReadLine());
if (S == a*a)
{
    Console.WriteLine("Верно");
}
else 
Console.WriteLine("Попробуйте другое");
