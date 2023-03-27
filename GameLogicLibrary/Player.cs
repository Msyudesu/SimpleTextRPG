using System.Collections.Generic;

namespace GameLogicLibrary
{
    public class Player
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int Armor { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int NextLevelExperience { get; set; }
        public Stats Stats { get; set; }
        public int Gold { get; set; }
        public List<IAbility> Skills = new List<IAbility>();
        public Dictionary<IItem, int> Inventory = new Dictionary<IItem, int>();
        public Armor Helm { get; set; }
        public Armor Chest { get; set; }
        public Armor Pants { get; set; }
        public Armor Boots { get; set; }
        public Armor Belt { get; set; }
        public Armor Ring { get; set; }
        public Armor Weapon { get; set; }
        public Armor Shield { get; set; }
        public Armor Bow { get; set; }
        public int xPosition { get; set; }
        public int yPosition { get; set; }

        public Player(string name, string characterClass)
        {
            this.Name = name;
            this.CharacterClass = characterClass;
            this.Armor = 0;
            this.Gold = 5;
            this.Experience = 0;
            this.NextLevelExperience = 100;
            this.Inventory.Add(new Potion("Minor Healing Potion", 1, 20), 5);  // Starting 5 health potions.
            this.Stats = new Stats(70, 70, 70, 70, 70, 100, 200);
        }

        public void Move(char direction, Map map)
        {
            int previousX = xPosition;
            int previousY = yPosition;

            switch (direction)
            {
                case 'N':
                    yPosition -= 1;
                    break;
                case 'E':
                    xPosition += 1;
                    break;
                case 'S':
                    yPosition += 1;
                    break;
                case 'W':
                    xPosition -= 1;
                    break;
            }
            if (map.MoveAttemptIsValid(xPosition, yPosition))
                map.UpdatePlayerPosition(this, previousX, previousY);
            else
            {
                xPosition = previousX;
                yPosition = previousY;
            }

        }

        public void Attack()
        {

        }

        public void FindPlayerPosition(Map gamemap)
        {
            for (int y = 0; y < gamemap.WorldMap.Length; y++)
            {
                for (int x = 0; x < gamemap.WorldMap[y].Length; x++)
                {
                    if (gamemap.WorldMap[y][x] == '@')
                    {
                        this.xPosition = x;
                        this.yPosition = y;
                        break;
                    }
                }
            }
        }

        public void LevelUp()
        {
            this.Level += 1;
            this.Experience = 0;
            this.NextLevelExperience = 100 + (this.Level * (this.Level ^ 2));
        }
    }
}
