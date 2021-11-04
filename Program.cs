using System;

namespace GladiatorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Magician magic = new Magician();
            Tank tank = new Tank();
            for (int i=0; i < 50; i++)
            {
                magic.StartGame(tank);
                tank.StartGame(magic);
                Console.ReadKey();
            }
        }
    }
}
