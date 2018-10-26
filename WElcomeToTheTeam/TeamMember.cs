using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheTeam
{
    class TeamMember : Person
    {
        string FirstName;
        string LastName;
        string EmailAddress;
        int Age;
        int Salary;
        string MailAddress;

        public TeamMember(string firstName, string lastName, string emailAddress, int age, int salary, string mailAddress) : base(firstName, lastName, emailAddress, age)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Age = age;

            Salary = salary;
            MailAddress = mailAddress;

            //Console.WriteLine("Salary: ");
            //salary = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Mainling address: ");
            //MailAddress = Console.ReadLine();

        }
        public override void Play()
        {
            Console.WriteLine("\nFirst Name: {0} \nLast Name: {1} \nEmail Address: {2} \nAge: {3} \nSalary: {4} \nMailing Address: {5}", FirstName, LastName, EmailAddress, Age, Salary, MailAddress);
        }
    }
}
