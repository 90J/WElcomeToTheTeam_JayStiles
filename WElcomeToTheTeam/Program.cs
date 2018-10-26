using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToTheTeam

{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

        Start:

            Person[] person = new Person[num];
            person[0] = new Person("Jay", "Stiles", "JayStiles@quickenloans.com", 43);
            person[1] = new Person("Tim", "Bro", "TimBroughton@quickenloans.com", 26);
            person[2] = new TeamMember("Jim", "Jones", "Jimmy@quickenloans.com", 65, 12500, "225 West Elm");

            foreach (Person character in person)
            {
                character.Play();
            }

            //Get userInput

            


            Console.WriteLine("");
            Console.WriteLine("Enter the following requested information");
            Console.Write("First name: ");
            string userInputFN = Console.ReadLine();



            Console.Write("Last name: ");
            string userInputLN = Console.ReadLine();

            Console.Write("Email address: ");
            string userInputEA = Console.ReadLine();

            Console.Write("Age: ");
            int userInputAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Salary: ");
            int userInputSalary = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mailing Address: ");
            string unserInputMailAddress = Console.ReadLine();


            if (userInputAge < 18)
            {
                Console.WriteLine("Cannot add minors, add someone that is over 18.");
                goto Start;
            }
            else
            {
                num = num + 1;
                Person[] x = new Person[num+1];
                x[num+1] = new Person(userInputFN, userInputLN, userInputEA, userInputAge);

                goto Start;
            }
        }
    }
}
