using System;
namespace Work
{
    public delegate void EGreet(Person person, string time);
    public delegate void EPart(Person person);

    class Office
    {
        public event EGreet greet;
        public event EPart part;
        public void OnCameG(Person person, string time)
        {
            if (greet != null)
            {
                greet(person, time);

            }
        }

        public void OnCameP(Person person)
        {
            if (part != null)
            {
                part(person);
            }
        }
    }
}
