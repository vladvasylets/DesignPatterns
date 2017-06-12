using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var turist = new Turist();
            var car = new Car();
            turist.Travel(car);

            var camel = new Camel();
            ITransport adapter = new CamelToCarAdapter(camel);
            turist.Travel(adapter);
        }
    }

    public interface ITransport
    {
        void Drive();
    }

    public class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Drive by a car on the road.");
        }
    }

    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Travel on camel on the sand.");
        }
    }

    public interface IAnimal
    {
        void Move();
    }

    public class Turist
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }

    public class CamelToCarAdapter: ITransport
    {
        Camel _camel;

        public CamelToCarAdapter(Camel camel)
        {
            this._camel = camel;
        }

        public void Drive()
        {
            this._camel.Move();
        }
    }
}
