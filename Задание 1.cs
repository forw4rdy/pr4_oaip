Console.WriteLine("Введите строку:");
string text = Console.ReadLine();

string result = "";

for (int i = 0; i < text.Length; i++)
{
    if (i % 2 == 1)
    {
        result += text[i].ToString().ToUpper();
    }
    else
    {
        result += text[i];
    }
}

Console.WriteLine("Результат:");
Console.WriteLine(result);