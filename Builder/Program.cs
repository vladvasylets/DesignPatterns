using System;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new LaptopBuilder();
            var shop = new Shop(builder);
            var computer = shop.GetComputer();
            computer.GetInfo();
        }
    }

    public class Shop
    {
        ComputerBuilder _builder;
        public Shop(ComputerBuilder builder)
        {
            this._builder = builder;
        }

        public Computer GetComputer()
        {
            this._builder.SetHDD();
            this._builder.SetRAM();

            return this._builder.GetComputer();
        }
    }

    public abstract class ComputerBuilder
    {
        public ComputerBuilder()
        {
            this.Computer = new Computer();
        }
        public Computer GetComputer()
        {
            return this.Computer;
        }
        public Computer Computer { get; private set; }
        public abstract void SetRAM();
        public abstract void SetHDD();        
    }

    public class LaptopBuilder : ComputerBuilder
    {
        public override void SetHDD()
        {
            this.Computer.HDD =  "500 Gb";
        }

        public override void SetRAM()
        {
            this.Computer.RAM = "8 Gb";
        }
    }

    public class Computer
    {
        public string HDD { get; set; }
        public string RAM { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"RAM - {this.RAM}, HDD - {this.HDD}");
        }
    }

}
