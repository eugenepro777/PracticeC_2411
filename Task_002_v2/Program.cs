// Напишите программу, которая выводит на консоль таблицу умножения.
// Реализовать через массив и метод, используя цикл foreach

int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

void Table(int[] arrayOut)
{
    foreach (int i in arrayOut)
    {
        foreach (int j in arrayOut)
        {
            int result = i * j;
            Console.Write("{0}x{1}={2}\t", i, j, result);
        }
        Console.WriteLine();
    }
}

Table(array);