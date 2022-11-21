Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int third = Convert.ToInt32(Console.ReadLine());

int max = first;

if (first > second)
{
    if (first > third)
    {
        max = first;
    }
    else
    {
        max = third;
    }
}

else
{
    if (second > third)
    {
        max = second;
    }
    else
    {
        max = third;
    }
}

Console.WriteLine($"{max} = максимальное число выборки.");