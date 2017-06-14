using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var samsungFactory = new SamsungFactory();
            var samsungPhone = samsungFactory.GetPhone();
            var samsungTablet = samsungFactory.GetTablet();

            Console.WriteLine("Samsung factory:");
            Console.WriteLine($"Phone - {samsungPhone.Name}\nTablet - {samsungTablet.Name}");

            var appleFactory = new AppleFactory();
            var applePhone = appleFactory.GetPhone();
            var appleTablet = appleFactory.GetTablet();

            Console.WriteLine("Apple factory:");
            Console.WriteLine($"Phone - {applePhone.Name}\nTablet - {appleTablet.Name}");
        }
    }

    public interface IFactory
    {
        Phone GetPhone();
        Tablet GetTablet();
    }

    public class AppleFactory : IFactory
    {
        public Phone GetPhone()
        {
            return new IPhone();
        }

        public Tablet GetTablet()
        {
            return new IPad();
        }
    }

    public class SamsungFactory : IFactory
    {
        public Phone GetPhone()
        {
            return new SamsungS8();
        }

        public Tablet GetTablet()
        {
            return new SamsungTab4();
        }
    }

    public abstract class Phone
    {
        public string Name {get; set; }
    }

    public class IPhone: Phone
    {
        public IPhone()
        {
            this.Name = "IPhone 7.";
        }
    }

    public class SamsungS8: Phone
    {
        public SamsungS8()
        {
            this.Name = "Samsung Galaxy S8.";
        }
    }

    public abstract class Tablet
    {
        public string Name { get; set; }
    }

    public class IPad: Tablet
    {
        public IPad()
        {
            this.Name = "Apple Ipad Pro 12\".";
        }
    }

    public class SamsungTab4: Tablet
    {
        public SamsungTab4()
        {
            this.Name = "Samsung Galaxy Tab 4.";
        }
    }
}
