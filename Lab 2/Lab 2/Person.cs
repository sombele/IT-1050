using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;

        public Person Spouse;


        public static double SumOfAllAges;


        public string GetFullName()
        {
            return this.FirstName + ", " + this.LastName;
        }


        public void AskUserForNameAndAge()
        {
            System.Console.Write("Enter Your First Name               : ");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("Enter Your Last Name                : ");
            this.LastName = System.Console.ReadLine();

            System.Console.Write("Enter Your Age                      : ");
            this.Age = int.Parse(System.Console.ReadLine());

            this.Spouse = new Person();
            System.Console.Write("Enter Your Spouse's First Name      : ");
            this.Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("Enter Your Spouse's Age             : ");
            this.Spouse.Age = int.Parse(System.Console.ReadLine());
            this.Spouse.LastName = this.LastName;
            Person.SumOfAllAges += this.Age + this.Spouse.Age;

        }


        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName() + "   " + (Age));
            System.Console.WriteLine(this.Spouse.GetFullName() + "   " + (Age));
            System.Console.WriteLine("");
        }

        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / 4;
        }
    }
}


