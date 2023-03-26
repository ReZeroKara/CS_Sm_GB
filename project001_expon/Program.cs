Console.Write("Введите число для возведения в квадрат: ");

int n = 0;

if (int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine(n * n);
}
else
{
    Console.WriteLine("Неверный ввод");
}