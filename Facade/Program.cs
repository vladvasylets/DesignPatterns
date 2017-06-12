using System;
using static System.Console;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileDeveloper = new MobileDeveloper();
            var webDeveloper = new  WebDeveloper();
            var designer = new Designer();
            var company = new CompanyFacade(designer, webDeveloper, mobileDeveloper);
            var client = new Client(company);

            client.BuyWebsite();
            client.BuyAndroidApp();
            client.BuyIPhoneApp();
        }
    }

    public class Client
    {
        CompanyFacade _facade;

        public Client(CompanyFacade facade)
        {
            this._facade = facade;
        }

        public void BuyWebsite()
        {
            WriteLine("I want a new web site.");
            this._facade.DevelopWebsite();
        }

        internal void BuyAndroidApp()
        {
            WriteLine("I want a new Android app.");
            this._facade.DevelopAndroidApp();
        }

        internal void BuyIPhoneApp()
        {
            WriteLine("I want a new IPhone app.");
            this._facade.DevelopIPhoneApp();
        }
    }
    public class CompanyFacade
    {
        Designer _designer;
        WebDeveloper _webDeveloper;
        MobileDeveloper _mobileDeveloper;

        public CompanyFacade(
            Designer designer, 
            WebDeveloper webDeveloper, 
            MobileDeveloper mobileDeveloper)
        {
            this._designer = designer;
            this._mobileDeveloper = mobileDeveloper;
            this._webDeveloper = webDeveloper;
        }

        public void DevelopWebsite()
        {
            this._designer.CreateWebSiteDesign();
            this._webDeveloper.CreateWebsite();
        }

        public void DevelopIPhoneApp()
        {
            this._designer.CreateMobileAppDesign();
            this._mobileDeveloper.CreteIPhoneApp();
        }

        public void DevelopAndroidApp()
        {
            this._designer.CreateMobileAppDesign();
            this._mobileDeveloper.CreateAndroidApp();
        }
    }

    public class Designer
    {
        public void CreateMobileAppDesign()
        {
            WriteLine("Company created a design of a mobile app.");
        }

        public void CreateWebSiteDesign()
        {
            WriteLine("Company created a design of a website.");
        }
    }

    public class WebDeveloper
    {
        public void CreateWebsite()
        {
            WriteLine("Company created a website.");
        }
    }

    public class MobileDeveloper
    {
        public void CreteIPhoneApp()
        {
            WriteLine("Company created a IPhone app.");
        }

        public void CreateAndroidApp()
        {
            WriteLine("Company created an Android app.");
        }
    }
}
