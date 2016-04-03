using System;
using EventExample.Interfaces;

namespace EventExample.Model
{
    public class Scheduler : IScheduler
    {
        public event SchedulerActionHandler SchedulerAction;

        public void StartEmulation()
        {
            Person[] persons =
            {
                new Person("Джон"),
                new Person("Билл"),
                new Person("Хьюга")
            };
            persons[0].Time = new DateTime(2008, 1, 2, 11, 30, 15);
            persons[1].Time = new DateTime(2008, 1, 2, 13, 30, 15);
            persons[2].Time = new DateTime(2008, 1, 2, 18, 30, 15);
            FireSchedulerActionEvent(persons[0], true);
            FireSchedulerActionEvent(persons[1], true);
            FireSchedulerActionEvent(persons[2], true);
            FireSchedulerActionEvent(persons[0], false);
            FireSchedulerActionEvent(persons[1], false);
            FireSchedulerActionEvent(persons[2], false);
        }

        protected void FireSchedulerActionEvent(Person person, bool isCommingIn)
        {
            var e = SchedulerAction;
            if (e != null)
                e(new ActionEventArg(person, isCommingIn ? ActionType.ComeIn : ActionType.ComeOut));
        }
    }
}
