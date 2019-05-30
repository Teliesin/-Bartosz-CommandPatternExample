using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    public class MoveCommand : ICommand
    {
        Robot Robot { get; set; }

        Direction Direction { get; set; }

        public  MoveCommand(Robot robot, Direction direction)
        {
            Robot = robot;
            Direction = direction;
        }

        public void Execute()
        {
            switch(Direction)
            {
                case Direction.Front:
                    {
                        Robot.Y += 1;
                    }
                    break;
                case Direction.Back:
                    {
                        Robot.Y -= 1;
                    }
                    break;
                case Direction.Left:
                    {
                        Robot.X -= 1;
                    }break;
                case Direction.Right:
                    {
                        Robot.X += 1;
                    }
                    break;
            }
        }
    }
}