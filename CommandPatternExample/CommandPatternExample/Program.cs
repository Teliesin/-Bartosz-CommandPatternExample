using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();

            area.Fields[4][6] = "Klocek";

            Robot robot = new Robot();
            robot.X = 5;
            robot.Y = 5;

            ICommand command1 = new MoveCommand(robot, Direction.Left);
            ICommand command2 = new MoveCommand(robot, Direction.Front);
            ICommand command3 = new GrabCommand(area, robot);

            List<ICommand> commands = new List<ICommand>();

            commands.Add(command1);
            commands.Add(command2);
            commands.Add(command3);

            //dużo kodu

            commands.ForEach(command => command.Execute());

            Console.WriteLine(robot.Hands);

            Console.ReadKey();
        }
    }
}