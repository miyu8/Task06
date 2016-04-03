using System.Collections.Generic;
using EventExample.Model;

namespace EventExample.Interfaces
{
    public delegate void IncommingHandler(Person person);
    public delegate void LeavingHandler(Person person);
    public interface IOffice : ISchedulerListener
    {
        event IncommingHandler IncommingEvent;
        event LeavingHandler LeavingEvent;
        void AddPersonToOffice(Person person);
        void RemovePersonFromOffice(Person person);
        List<Person> GetAllPresentingPersons();
    }
}
