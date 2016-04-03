using System.Collections.Generic;
using EventExample.Interfaces;

namespace EventExample.Model
{
    public class Office : IOffice
    {
        public event IncommingHandler IncommingEvent;
        public event LeavingHandler LeavingEvent;
        private List<Person> allPersons = new List<Person>();

        public void AddPersonToOffice(Person person)
        {
            if (allPersons.Contains(person))
                return;
            allPersons.Add(person);
            FireIncommingEvent(person);
            this.IncommingEvent += person.OnIncomming;
            this.LeavingEvent += person.OnLeaving;
        }

        public List<Person> GetAllPresentingPersons()
        {
            return allPersons;
        }

        public void OnSchedulerAction(ActionEventArg arg)
        {
            if (arg.ActionType == ActionType.ComeIn)
                AddPersonToOffice(arg.Person);
            if (arg.ActionType == ActionType.ComeOut)
                RemovePersonFromOffice(arg.Person);
        }

        public void RemovePersonFromOffice(Person person)
        {
            if (!allPersons.Contains(person))
                return;
            this.IncommingEvent -= person.OnIncomming;
            this.LeavingEvent -= person.OnLeaving;
            allPersons.Remove(person);
            FireLeavingEvent(person);
        }

        protected void FireIncommingEvent(Person person)
        {
            var e = IncommingEvent;
            if (e != null)
                e(person);
        }
        protected void FireLeavingEvent(Person person)
        {
            var e = LeavingEvent;
            if (e != null)
                e(person);
        }
    }
}
