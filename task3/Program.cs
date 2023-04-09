// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

cube(Read());

int Read()
{
    System.Console.Write("Введи число: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("Вводи цифры!");
    }
    return number;
}

void cube(int number)
{
    int num = 1;
    int L = Read();
    while (num <= L)
    {
        double i=Math.Pow(num, 3);
        Console.Write(i+" ");
        num++;
    }
}