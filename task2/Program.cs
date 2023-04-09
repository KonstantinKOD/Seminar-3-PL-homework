// Напишите программу, 
// которая принимает на вход
// координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

internal class Program
{
    private static void Main(string[] args)
    {
        int Read(string arg)
        {
            System.Console.WriteLine($"Вводи давай {arg}");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                System.Console.WriteLine("Нудны циферки, а не буковки. Давай без шуток!");
            }
            return number;
        }

        double lenght()
        {
            int x1 = Read("x1");
            int y1 = Read("y1");
            int z1 = Read("z1");
            int x2 = Read("x2");
            int y2 = Read("y2");
            int z2 = Read("z2");
            double len = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2)
                        + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 3);
            return len;
        }

        double L = lenght();
        System.Console.WriteLine($"Координаты точки: {L}, вот так, голубчик!");
    }
}