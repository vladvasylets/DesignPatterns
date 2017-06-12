using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new ItalianPizza();
            Console.WriteLine($"Name: {pizza.Name}");
            Console.WriteLine($"Price: {pizza.GetCost()}");

            pizza = new GermanPizza(pizza);
            Console.WriteLine($"Name: {pizza.Name}");
            Console.WriteLine($"Price: {pizza.GetCost()}");
        }
    }

    public abstract class Pizza
    {
        public string Name { get; set; }

        public Pizza(string name)
        {
            this.Name = name;
        }

        public abstract int GetCost();
    }

    public class ItalianPizza: Pizza
    {
        public ItalianPizza(): base("Italian pizza")
        { }

        public override int GetCost()
        {
            return 10;
        }
    }

    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza _pizza { get; set; }
        public PizzaDecorator(Pizza pizza, string name) : base(name)
        {
            this._pizza = pizza;
        }
    }

    public class GermanPizza : PizzaDecorator
    {
        public GermanPizza(Pizza pizza) : base(pizza, pizza.Name)
        {
            this.Name = $"{pizza.Name} with bavarian sausages";
        }

        public override int GetCost()
        {
            return this._pizza.GetCost() + 10;
        }
    }
}

    