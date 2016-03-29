using System;

namespace Work
{
    public class Person
    {
        public string name;
        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("[На работу пришёл {0}]", this.name);
        }

        public Person(string name, bool bo)
        {
            this.name = name;
            Console.WriteLine("[{0} ушёл домой]", this.name);
        }
        public void Greeting(Person person, string time)
        {
            if (string.Compare("12", time) > 0)
            {
                Console.WriteLine("'[Доброе утро, {0}]', - сказал {1}", person.name, this.name);
            }
            else if (string.Compare("17", time) > 0)
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
