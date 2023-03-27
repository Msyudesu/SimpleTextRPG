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
            Map gamemap = new Map();
            Player player = new Player("Msyu", "Rogue");

            gamemap.LoadMap(1);
            gamemap.RenderToConsole();
            int x = player.xPosition = 3;
            int y = player.yPosition = 27;
            gamemap.WorldMap[y][x] = '@';

            for (int i = 0; i < 20; i++)
            {
                player.Move('N', gamemap);
                Console.WriteLine($"Player is currently at: X: {player.xPosition}, Y: {player.yPosition}");
                Thread.Sleep(250);
            }
            for (int i = 0; i < 10; i++)
            {
                player.Move('E', gamemap);
                Console.WriteLine($"Player is currently at: X: {player.xPosition}, Y: {player.yPosition}");
                Thread.Sleep(250);
            }

            while (true)
            {
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
