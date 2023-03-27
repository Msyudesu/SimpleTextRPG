using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLibrary
{
    public interface IItem
    {
        string Name { get; set; }
        int Level { get; set; }

        void Use(Player player);
    }
}
