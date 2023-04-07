using System;
using GameLogicLibrary;
using System.Threading;

namespace MsyuRPGConsoleUI
{
    class Program
    {

        static void Main()
        {
            // Simulated For now.
            Map gamemap = new Map(level: 1);
            Player player = new Player("Msyu", "Rogue");
            int x = player.xPosition = 3;
            int y = player.yPosition = 27;
            gamemap.WorldMap[y][x] = '@';

            while (true)
            {
                Console.Clear();
                Console.WriteLine(gamemap);
                Console.WriteLine($"Player is currently at: X: {player.xPosition}, Y: {player.yPosition}");
                Console.WriteLine("Where to move to? (N, E, S, W)");
                char moveOption;
                try
                {
                    moveOption = Convert.ToChar(Console.ReadLine().ToUpper());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine($"Error: {fe.Message}");
                    continue;
                }
                foreach (char c in "NESW")
                {
                    if (moveOption == c)
                    {
                        player.Move(Convert.ToChar(moveOption), gamemap);
                    }
                }
            }
        }
    }
}
