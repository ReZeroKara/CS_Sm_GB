//Программа для проверки: является ли одно число квадратом второго

Console.Write("Введите первое число: ");
int a = 0;
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите второе число: ");
int b = 0;
int.TryParse(Console.ReadLine(), out b);
int c = b * b;

if(a == c)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}