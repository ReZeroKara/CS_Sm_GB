//На ввод даётся два числа, ищем меньшее, к нему прибавляем разницу между большим и меньшим столко раз, какова величина меньшего числа

int first = new Random().Next(1,1000);
Console.WriteLine("Первое число: " + first);
int second = new Random().Next(1,1000);
Console.WriteLine("Второе число: " + second);

int max = 0;
int min = 0;

if (first > second)
{
    max = first;
    min = second;
}
else
{
    max = second;
    min = first;
}

Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);

int count = 0;
int result = min;

while(count < min)
{
    result = result + (max - min);
    count++;
}

Console.WriteLine("Результат: " + result);