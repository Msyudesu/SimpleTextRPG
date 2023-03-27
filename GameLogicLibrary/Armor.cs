using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLibrary
{
    public class Armor : IItem
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Dictionary<string, int?> Stats { get; set; }

        public Armor(string name, int level, Dictionary<string, int?> stats)
        {
            this.Name = name;
            this.Level = level;
            this.Stats = stats;
        }

        public void Use(Player player)
        {

        }
    }
}
