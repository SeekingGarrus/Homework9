// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int Number(string message) // ввод числа N
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool ValidateNumber(int number) // функция bool для проверки на положительность
{
    if (number < 1)
    {
        Console.WriteLine("Это не положительное число!");
        return false;
    }
    return true;
}

void PrintNaturalNum(int n) //вывод с рекурсией
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNaturalNum(n - 1);
}


int n = Number("Введите любое положительное число: ");
ValidateNumber(n);
PrintNaturalNum(n);