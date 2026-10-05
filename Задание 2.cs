Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Числа от 0 до " + number + ":");

for (int i = 0; i <= number; i++)
{
    Console.WriteLine(i);
}