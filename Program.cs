/*
Console.WriteLine("Введите трехзначное число:");
string input = Console.ReadLine();
Console.WriteLine("{0}->{1}",input, input[1]);
*/

/*
int ThirdDigit(int number)
{
    int result = -1;    
    if (number >=100)
    {
        while (number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
    }
return result; 
}

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (ThirdDigit(number1) == -1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"Третья цифра: {ThirdDigit(number1)}");
*/

int dayNumber = ReadInt("Введите номер дня от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write( + a + " день - Выходной");
        }
        else
        {
            Console.Write( + a + " день - Рабочий");
        }
    }
    else
    {
        Console.Write("Это число не соответствует значению от 1 до 7!");
    }
    return " день.";
}