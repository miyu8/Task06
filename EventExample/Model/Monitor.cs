using System;

namespace EventExample.Model
{
    public class Monitor
    {
        public void OnIncomming(Person person)
        {
            Console.WriteLine("[На работу пришёл {0}]", person.Name);
        }
        public void OnLeaving(Person person)
        {
            Console.WriteLine("[{0} ушёл домой]", person.Name);
        }
    }
}
