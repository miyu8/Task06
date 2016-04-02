using System;
using Errors;

namespace EventExample.Model
{
    public class Person
    {
        public string Name { get; private set; }
        public DateTime Time;
        public Person(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new PersonError();
            Name = name;
        }
        public void OnIncomming(Person person)
        {
            if (Time.Hour < 12)
            {
                Console.WriteLine("'[Доброе утро, {0}]', - сказал {1}", person.Name, this.Name);
            }
            else if (Time.Hour < 17)
            {
                Console.WriteLine("'[Добрый день, {0}]', - сказал {1}", person.Name, this.Name);
            }
            else
            {
                Console.WriteLine("'[Добрый вечер, {0}]', - сказал {1}", person.Name, this.Name);
            }
        }
        public void OnLeaving(Person person)
        {
            Console.WriteLine("'[До свидания, {0}]', - сказал {1}", person.Name, this.Name);
        }

    }

}
