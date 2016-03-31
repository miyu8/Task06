using System;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();
            Person person = office.Init("Джон");
            EGreet greet = office.ggreet(person);
            EPart part = office.ppart(person);
            person = office.Init("Билл");
            DateTime date = new DateTime(2008, 1, 2, 11, 30, 15);
            office.OnCameG(greet, person, date);
            greet += office.ggreet(person);
            part += office.ppart(person);
            person = office.Init("Хьюга");
            date = new DateTime(2008, 1, 2, 16, 30, 15);
            office.OnCameG(greet, person, date);
            greet += office.ggreet(person);
            part += office.ppart(person);

            person = office.Final(part, "Джон");
            part = office.fpart(part, "Джон");
            office.OnCameP(part, person);
            greet = office.fgreet(greet, "Джон");            
            office.Tablo(greet);
            person = office.Final(part, "Билл");
            part = office.fpart(part, "Билл");
            office.OnCameP(part, person);
            greet = office.fgreet(greet, "Билл");
            office.Tablo(greet);
            person = office.Final(part, "Хьюга");
            part = office.fpart(part, "Хьюга");
            office.OnCameP(part, person);
            greet = office.fgreet(greet, "Хьюга");
            office.Tablo(greet);

            Console.ReadKey();
        }
    }
}
