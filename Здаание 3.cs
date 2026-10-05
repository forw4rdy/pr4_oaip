int[] numbers = new int[5];

Console.WriteLine("Введите 5 элементов массива:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Введите элемент " + (i + 1) + ":");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Массив в обратном порядке:");

for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}