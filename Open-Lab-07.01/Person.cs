using System;

namespace Open_Lab_07._01
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime bornIn)
        {
            FirstName = firstName;
            LastName = lastName;
            BornIn = bornIn;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BornIn { get; }

        public TimeSpan GetAge()
        {
            throw new NotImplementedException();
        }
    }
}