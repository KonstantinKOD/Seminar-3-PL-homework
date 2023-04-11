// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

internal class Program
{
    private static void Main(string[] args)
    {
        cube(Read());

        int Read()
        {
            Console.Write("Введи число: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Вводи цифры!");
            }
            return number;
        }

        void cube(int num)
        {

// можно использовать цикл "for"
// 
//          for (double i = 1; i < num; i++)
//          {
//              double cb = Math.Pow(i, 3);
//              Console.Write(cb+" ");
//          }

            int i = 1;
            while (i <= num)
            {
                double cb = Math.Pow(i, 3);
                Console.Write(cb + " ");
                i++;
            }
        }
    }
}
