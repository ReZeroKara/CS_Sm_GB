//Программа, которая принимает на вход трёхзначиное число и на выходе показывает последнюю цифру

Console.Write("Введите трёхзначное число: ");
int n = int.Parse(Console.ReadLine());

if(n < 100)
{
    Console.WriteLine("Неверный ввод!");
}
else if(n > 999)
{
    Console.WriteLine("Неверный ввод!");
}
else
{
    int result = n % 10;
    Console.WriteLine(result);
}