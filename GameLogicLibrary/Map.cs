using System;
using System.Text;
using System.IO;

namespace GameLogicLibrary
{
    public class Map
    {
        public char[][] WorldMap = new char[30][];
        public char[][] BaseWorldMap = new char[30][];  // For reference when resetting a tile the player moves off of.
        public int CurrentLevel { get; set; }
        private char[] illegalSpaces = new char[] { '#', '^', 'T' };

        public void LoadMap(int level)
        {
            string filepath = $"Maps/{level}_Level.txt";
            string mapdata;
            using (StreamReader r = new StreamReader(filepath))
            {
                mapdata = r.ReadToEnd();
            }

            string[] mapLines = mapdata.Split('\n');

            for (int i = 0; i < mapLines.Length; i++)
            {
                WorldMap[i] = mapLines[i].ToCharArray();
                BaseWorldMap[i] = mapLines[i].ToCharArray();
            }
        }

        public void RenderToConsole()
        {
            StringBuilder sb = new StringBuilder();
            Console.Clear();
            for (int y = 0; y < WorldMap.Length; y++)
            {
                for (int x = 0; x < WorldMap[y].Length; x++)
                {
                    sb.Append(WorldMap[y][x]);
                }
                sb.Append("\n");
            }
            Console.WriteLine(sb.ToString());
        }

        public void SaveToTxtFile()
        {
            string filepath = $"Maps/{CurrentLevel}_Level.txt";
            StringBuilder sb = new StringBuilder();
            using (StreamWriter w = new StreamWriter(filepath))
            {
                for (int y = 0; y < WorldMap.Length; y++)
                {
                    for (int x = 0; x < WorldMap[y].Length; x++)
                    {
                        sb.Append(WorldMap[y][x]);
                    }
                }
                w.Write(sb.ToString());
            }
        }

        public bool MoveAttemptIsValid(int x, int y)
        {
            foreach (char c in illegalSpaces)
                if (WorldMap[y][x] == c)
                    return false;
            return true;
        }

        public void UpdatePlayerPosition(Player player, int x, int y)
        {
            WorldMap[player.yPosition][player.xPosition] = '@';
            WorldMap[y][x] = BaseWorldMap[y][x];
            RenderToConsole();
        }
    }
}
