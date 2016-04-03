using EventExample.Model;

namespace EventExample.Interfaces
{
    public interface ISchedulerListener
    {
        void OnSchedulerAction(ActionEventArg arg);
    }
}
