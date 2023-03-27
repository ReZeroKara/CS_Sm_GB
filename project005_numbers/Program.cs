//Программа принимает на вход число n и показывает все числа в диапазоне -n до n

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int count1 = 0;
int count2 = (n * 2) + 1;
int a = 0;

while(count1 < count2)
{
    int result = a - n;
    Console.Write(result + ", ");
    a++;
    count1++;
}