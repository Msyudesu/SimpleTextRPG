using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogicLibrary
{
    public partial class MovableEntity : IMovableEntity
    {
        public string Name { get; set; }
        public int xPosition { get; set; }
        public int yPosition { get; set; }
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
    }
}
