// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.


int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m -1, Ackermann(m, n -1));
    }
}

InputOutputValues();
void InputOutputValues()
{
    Console.WriteLine("Введите значение для m");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение для n");
    int n = Convert.ToInt32(Console.ReadLine());

    int output = Ackermann(m, n);

    Console.WriteLine($"Значение для {m} и для {n} = {output}");
}
