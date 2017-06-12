using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var event1 = new CalendarPrototype
            {
                Company = "Microsoft",
                EventName = "First event",
                Date = new DateTime(2017, 8, 1)
            };
            CalendarPrototype.GetInfo(event1);

            var event2 = event1.Clone() as CalendarPrototype;
            event2.Date = new DateTime(2017, 09, 1);
            event2.EventName = "Second event";
            CalendarPrototype.GetInfo(event2);
        }
    }

    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class CalendarPrototype : Prototype
    {
        public string Company { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }

        public override Prototype Clone()
        {
            return (CalendarPrototype)this.MemberwiseClone();
        }

        public static void GetInfo(CalendarPrototype event1)
        {
            Console.WriteLine($"{event1.Company} organize {event1.EventName} on {event1.Date}");
        }
    }
}
