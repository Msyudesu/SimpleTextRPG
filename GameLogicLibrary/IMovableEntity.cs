using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLibrary
{
    public interface IMovableEntity
    {
        string Name { get; set; }
        int xPosition { get; set; }
        int yPosition { get; set; }
        void Move(char direction, Map map);
    }
}
