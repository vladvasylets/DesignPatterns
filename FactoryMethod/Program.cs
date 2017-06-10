using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DevCompany company1 = new Company1();
            company1.DevelopProject();

            DevCompany company2 = new Company2();
            company2.DevelopProject();
            Console.ReadKey();
        }
    }

    public abstract class DevCompany
    {       
        public abstract Project DevelopProject();
    }

    public class Company1: DevCompany
    {
        public override Project DevelopProject()
        {
            return new Website();
        }
    }

    public class Company2: DevCompany
    {
        public override Project DevelopProject()
        {
            return new MobileApp();
        }
    }
    
    public abstract class Project{}
    
    public class Website: Project
    {
        public Website()
        {
            Console.WriteLine("Website done.");
        }
    }

    public class MobileApp: Project
    {
        public MobileApp()
        {
            Console.WriteLine("Mobile app done.");
        }
    }
}
