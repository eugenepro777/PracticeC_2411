﻿// За каждый месяц банк начисляет к сумме вклада 7% от суммы.
// Напишите консольную программу, в которую пользователь вводит сумму вклада
// и количество месяцев.
// А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.

// Для вычисления суммы с учетом процентов используйте цикл for.
// Для ввода суммы вклада используйте
// выражение Convert.ToDecimal(Console.ReadLine())
// (сумма вклада будет представлять тип decimal) 

Console.WriteLine("Введите сумму вклада: ");
decimal amount = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Введите длительность вклада: ");
int month = Convert.ToInt32(Console.ReadLine());

int percent = 7;

decimal PercentSearch(decimal num1, int num2)
{
    decimal result = num1;
    for (int i = 0; i < num2; i++)
    {
        result = result + result * percent / 100;
    }
    return result;
}
if(amount > 0)
{
    Console.WriteLine(PercentSearch(amount, month));
}
else
{
    Console.WriteLine("Вклад нулевой");
}