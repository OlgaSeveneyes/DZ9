// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
int m = NumberFromUser ("Введите число m: ","Ошибка ввода!");
int n = NumberFromUser ("Введите число n: ","Ошибка ввода!");
PrintNaturalNambersFromMToN(m, n);

// возвращает число, введенное пользователем, либо сообщение об ошибке

int NumberFromUser (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// возвращает натуральные числа в промежутке от M до N

string PrintNaturalNambersFromMToN(int start, int end)
{
    if (start == end +1)
    {
        return start.ToString();
    }
    else
    {
        if (start == end)
        {
            Console.Write($"{start}");
        }
        else 
        {
            Console.Write($"{start}, ");
        }
        return PrintNaturalNambersFromMToN(start+1, end);
    }
}