using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheTeam

{
    class Person
    {
        string FirstName;
        string LastName;
        string EmailAddress;
        int Age;




        public Person(string firstName, string lastName, string emailAddress, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Age = age;

            //Console.WriteLine("First Name: ");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Last name: ");
            //lastName = Console.ReadLine();
            //Console.WriteLine("Email Address : ");
            //emailAddress = Console.ReadLine();
            //Console.WriteLine("Age: ");
            //age = Int32.Parse(Console.ReadLine());
            

        }

        public virtual void Play()
        {
            Console.WriteLine("\nFirst name: {0} \nLast name {1} \nEmail Address: {2} \nAge: {3}", FirstName, LastName, EmailAddress, Age);
        }

    }
}
