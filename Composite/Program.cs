using System;
using System.Collections.Generic;
using static System.Console;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component menu = new Menu();
            Component menu1 = new Menu("Menu 1");
            menu1.Add(new HyperLink("Sub menu 1"));
            menu1.Add(new HyperLink("Sub menu 2"));
            menu1.Add(new HyperLink("Sub menu 3"));
            menu.Add(menu1);
            
            Component menu2 = new Menu("Menu 2");
            menu2.Add(new HyperLink("Sub menu 1"));
            menu2.Add(new HyperLink("Sub menu 2"));
            menu.Add(menu2);
            
            menu.Print();

        }
    }

    public abstract class Component
    {
        protected string _name;

        public Component(){}

        public Component(string name)
        {
            this._name = name;
        }

        public virtual void Add(Component component){}
 
        public virtual void Remove(Component component) { }
    
        public virtual void Print()
        {
            WriteLine(this._name);
        }
    }

    public class Menu : Component
    {
        private List<Component> _components = new List<Component>();

        public Menu(){}

        public Menu(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            this._components.Add(component);
        }

        public override void Remove(Component component)
        {
            this._components.Remove(component);
        }

        public override void Print()
        {
            WriteLine(this._name);

            foreach(var item in this._components)
            {
                item.Print();
            }
        }
    }

    public class HyperLink : Component
    {
        public HyperLink(string name) : base(name)
        {
        }
    }

}
