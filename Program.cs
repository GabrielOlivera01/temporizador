using System;

namespace Temporizador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Temporizador();
        }

        static void Temporizador()
        {
            Console.Clear();
            Console.WriteLine("Contar em Segundos => 10s = 10 segundos");
            Console.WriteLine("Contar em Minutos => 1m = 1 minuto");
            Console.WriteLine("0s = Sair");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Quanto tempo deseja contar?");

            string? data = Console.ReadLine().ToLower();

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                Console.Clear();
                System.Environment.Exit(0);
            }

            Start(time * multiplier);
        }

        static void MsgStart()
        {
            string? msg = "Parar = Ctrl + C";
            Console.WriteLine(msg);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                MsgStart();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Temporizador finalizado");
            Thread.Sleep(1500);

            Temporizador();
        }
    }
}
