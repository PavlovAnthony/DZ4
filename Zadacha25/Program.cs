string ReadData(string line)
{

    Console.Write(line);
    string a = Console.ReadLine();
    return a;
}

double  CheckNumber(string x)
{
    double num = 0;

    bool isNum = double.TryParse(x, out num);
    if (isNum == false)
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

double FindDegree(double a, double b)
{

    return Math.Pow(a, b);
}

double a = CheckNumber(ReadData("Введите число А, которое возводим в степень: "));
double b = CheckNumber(ReadData("Введите число B - степень числа А: "));

double result = FindDegree(a, b);
PrintData("Число A  в степени B: ", result.ToString());

