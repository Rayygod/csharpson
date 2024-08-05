using System.Diagnostics;

namespace csharpson;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Preste atenção no som");
        Console.WriteLine("Digite um numero entre os intervalos de 1 a 4");
        int beeps;
        beeps = int.Parse(Console.ReadLine());

        if (beeps == 1)
        {
            Console.Beep(600,800);
        }
        if (beeps == 2)
        {
            Console.Beep(500,800);
        }
        if (beeps == 3)
        {
            Console.Beep(400,800);
        }
        if (beeps == 4)
        {
            Console.Beep(300,800);
        }

    }
}
