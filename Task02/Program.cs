// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
int m = NumberFromUser ("Введите число m: ","Ошибка ввода!");
int n = NumberFromUser ("Введите число n: ","Ошибка ввода!");
PrintSumNambersFromMToN(m, n, 0);

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

// возвращает сумму натуральных элементов в промежутке от m до n

int PrintSumNambersFromMToN(int start, int end, int sum)
{
    if (start > end)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от m до n: {sum}");
        return start;
    }
    else
    {
        sum += start++;
        return PrintSumNambersFromMToN (start, end, sum);
    }
}