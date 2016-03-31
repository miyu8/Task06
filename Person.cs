using System;

namespace Work
{
    public class Person
    {
        public string name;

        public void Greeting(Person person, DateTime time)
        {
            if (time.Hour.CompareTo(12) < 0)
            {
                Console.WriteLine("'[Доброе утро, {0}]', - сказал {1}", person.name, this.name);
            }
            else if (time.Hour.CompareTo(17) < 0)
            {
                Console.WriteLine("'[Добрый день, {0}]', - сказал {1}", person.name, this.name);
            }
            else
            {
                Console.WriteLine("'[Добрый вечер, {0}]', - сказал {1}", person.name, this.name);
            }
        }

        public void Parting(Person person)
        {
            Console.WriteLine("'[До свидания, {0}]', - сказал {1}", person.name, this.name);
        }
    }
}
