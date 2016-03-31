using System;
namespace Work
{
    public delegate void EGreet(Person person, DateTime time);
    public delegate void EPart(Person person);

    public class Office
    {
        public event EGreet greet;
        public event EPart part;

        public void OnCameG(EGreet gree, Person person, DateTime time)
        {
            if (gree != null)
            {
                gree(person, time);

            }
        }

        public void OnCameP(EPart par, Person person)
        {
            if (par != null)
            {
                par(person);
            }
        }

        public Person Init(string name)
        {
            Person person = new Person();
            person.name = name;
            Console.WriteLine("[На работу пришёл {0}]", name);
            return person;
        }

        public Person Final(EPart part, string name)
        {
            
            if (part != null)
                foreach (EPart rec in part.GetInvocationList())
                {
                    if (((Person)rec.Target).name == name)
                    {
                        part -= rec;
                        Console.WriteLine("[{0} ушёл домой]", name);
                        return (Person)rec.Target;
                    }
                }
            return null;
        }

        public EGreet ggreet(Person person)
        {
            greet = person.Greeting;
            return greet;
        }

        public EPart ppart(Person person)
        {
            part = person.Parting;
            return part;
        }

        public EGreet fgreet(EGreet greet, string name)
        {
            foreach (EGreet rec in greet.GetInvocationList())
            {
                if (((Person)rec.Target).name == name)
                {
                    greet -= rec;
                    return greet;
                }
            }
            return null;          
        }

        public EPart fpart(EPart part, string name)
        {
            if (part != null)
                foreach (EPart rec in part.GetInvocationList())
                {
                    if (((Person)rec.Target).name == name)
                    {
                        part -= rec;
                        return part;
                    }
                }
            return null;
        }

        public void Tablo(EGreet greet)
        {
            if(greet!= null)
            foreach (EGreet rec in greet.GetInvocationList())
            {
                Console.WriteLine(((Person)rec.Target).name);
            }
        }
    }
}
