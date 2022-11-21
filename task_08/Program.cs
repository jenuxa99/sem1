Console.WriteLine("Введите Ваше число");
int v = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= v)
{
    Console.Write(count + " ");
    count = count +2;
}
Console.WriteLine();