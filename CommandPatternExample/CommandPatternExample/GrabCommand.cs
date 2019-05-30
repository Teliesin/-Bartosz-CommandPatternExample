using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    public class GrabCommand : ICommand
    {
        Area Area { get; set; }
        Robot Robot { get; set; }

        public GrabCommand(Area area, Robot robot)
        {
            Area = area;
            Robot = robot;
        }

        public void Execute()
        {
            Robot.Hands = Area.Fields[Robot.X][Robot.Y];
        }

    }
}
