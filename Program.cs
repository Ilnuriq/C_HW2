/*
Console.WriteLine("Введите трехзначное число:");
string input = Console.ReadLine();
Console.WriteLine("{0}->{1}",input, input[1]);
*/

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
