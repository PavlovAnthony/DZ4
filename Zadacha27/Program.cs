string ReadData(string line)
{

    Console.Write(line);
    string a = Console.ReadLine();
    return a;
}

int CheckNumber(string x)
{
    int num = 0;

    bool isNum = int.TryParse(x, out num);
    if (isNum == false || num < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        PrintData("Ошибка ввода: ", "значение Null либо введены не числа");
        Console.ResetColor();
        Environment.Exit(0);
    }
    return num;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

int FindSum(int a)
{
    string b = a.ToString();
    int result = 0;
    for (int i = 0; i <= b.Length - 1; i++)
    {

        result = result + (int)char.GetNumericValue(b[i]);

    }
    return result;
}

int a = CheckNumber(ReadData("Введите целое число А: "));
int result = FindSum(a);
PrintData("Сумма цифр введенного числа ", result.ToString());

