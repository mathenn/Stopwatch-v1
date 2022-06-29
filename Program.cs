using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Você acessou o Stopwatch :)");
            Console.WriteLine("");

            Console.WriteLine(" INSTRUÇÕES:");
            Console.WriteLine("");

            Console.WriteLine("S = Segundo > 10s = 10 segundos.");
            Console.WriteLine("M = Minuto > 10m = 10 minutos.");
            Console.WriteLine("0s ou 0m = Sair.");
            Console.WriteLine("");

            Console.WriteLine("Quanto tempo deseja cronometrar?");
            Console.WriteLine("");

            string data = Console.ReadLine();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            multiplier = 60;

            if (time == 0)
            {
                Console.Clear();
                Console.WriteLine("Obrigado por usar o Stopwatch!");
                Console.WriteLine("");
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(850);
            Console.WriteLine("Set...");
            Thread.Sleep(850);
            Console.WriteLine("Go!");
            Thread.Sleep(1200);
            Console.WriteLine("");

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Menu();
        }
    }
}