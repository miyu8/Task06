using System;
using EventExample.Interfaces;
using EventExample.Model;
using Errors;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IScheduler scheduler = new Scheduler();
                IOffice office = new Office();
                var monitor = new Monitor();
                office.IncommingEvent += monitor.OnIncomming;
                office.LeavingEvent += monitor.OnLeaving;
                scheduler.SchedulerAction += office.OnSchedulerAction;
                scheduler.StartEmulation();
            }
            catch (PersonError)
            {
                Console.WriteLine("Имя человека не может быть не заполнено");
            }
            Console.ReadKey();
        }
    }
}
