using System;
using static System.Console;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new RobotBombDestructor();
            var proxy = new RobotBombDestructorProxy(robot);

            proxy.FindBomb();
            proxy.Destruct();
        }
    }

    public class RobotBombDestructor
    {
        public virtual void FindBomb()
        {
            WriteLine("Find bomb.");
        }

        public virtual void Destruct()
        {
            WriteLine("Bomb is destructed.");
        }
    }

    public class RobotBombDestructorProxy: RobotBombDestructor
    {
        RobotBombDestructor _robot;

        public RobotBombDestructorProxy(RobotBombDestructor robot)
        {
            this._robot = robot;
        }

        public override void FindBomb()
        {
            WriteLine("Use proxy to manage a robot.");
            this._robot.FindBomb();
        }

        public override void Destruct()
        {
            WriteLine("Use proxy to manage a robot.");
            this._robot.Destruct();
        }
    }
}
