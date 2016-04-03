namespace EventExample.Model
{
    public enum ActionType
    {
        ComeIn,
        ComeOut,
    }

    public class ActionEventArg
    {
        public Person Person { get; private set; }
        public ActionType ActionType { get; private set; }
        public ActionEventArg(Person person, ActionType actionType)
        {
            Person = person;
            ActionType = actionType;
        }
    }
}
