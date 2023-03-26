//Программа определяет день недели по заданному номеру

Console.Write("Введите номер дня недели: ");
int day = 0;
int.TryParse(Console.ReadLine(), out day);

if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}
else if (day == 3)
{
    Console.WriteLine("Среда");
}
else if (day == 4)
{
    Console.WriteLine("Четверг");
}
else if (day == 5)
{
    Console.WriteLine("Пятница");
}
else if (day == 6)
{
    Console.WriteLine("Суббота");
}
else if (day == 7)
{
    Console.WriteLine("Воскресенье");
}
else if (day > 7)
{
    Console.WriteLine("Столько дней в неделе не бывает;)");
}
else
{
    Console.WriteLine("Не правильный ввод!");
}