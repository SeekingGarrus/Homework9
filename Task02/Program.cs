// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int GetNumber(string text) // функция для ввода числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int NaturalSum(int m, int n) // функция нахождения суммы с рекурсией
{
    if (m == n || m < 0 || n < 0)
        return n;
    return n + NaturalSum(m, n - 1);
}


void ValidateNumber(int m, int n) // метод для проверки на положительность и вывод
{
    if (m < 0 || n < 0) Console.WriteLine("Это не положительное число!");
    else Console.WriteLine($"Сумма элементов в промежутке {m} до {n} включительно: {NaturalSum(m, n)}");
}


int m = GetNumber("Введите положительное число M: ");
int n = GetNumber("Введите положительное число N: ");
NaturalSum(m, n);
ValidateNumber(m, n);