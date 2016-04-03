using EventExample.Model;

namespace EventExample.Interfaces
{
    public delegate void SchedulerActionHandler(ActionEventArg arg);
    public interface IScheduler
    {
        event SchedulerActionHandler SchedulerAction;
        void StartEmulation();
    }
}
