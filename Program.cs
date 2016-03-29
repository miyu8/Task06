namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();
            Person person = new Person("Джон");
            office.greet += person.Greeting;
            office.part += person.Parting;
            person = new Person("Билл");
            office.OnCameG(person, "12");
            office.greet += person.Greeting;
            office.part += person.Parting;
            person = new Person("Хьюга");
            office.OnCameG(person, "17");
            person = new Person("Хьюга", true);
            office.greet -= person.Greeting;
            office.part -= person.Parting;
            office.OnCameP(person);
            person = new Person("Билл",true); 
            office.greet -= person.Greeting;
            office.part -= person.Parting; // Как определить -= чтобы оно удалило Билла из списка
            office.OnCameP(person);
            person = new Person("Джон",true);
        }
    }
}
