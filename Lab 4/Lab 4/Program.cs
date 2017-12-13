using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Are you purchasing Matinee or Evening ticket? ");
            string movieTimes = System.Console.ReadLine();
            double totalPeople;
            double smallsoda;
            double largesoda;
            double hotdogs;
            double popcorns;
            double candies;
            double concessionStand;
            double totalCost;

            if (movieTimes == "Matinee")
            {
                System.Console.WriteLine("Your purchase is for Matinee!");

                System.Console.Write("How many Children tickets are you purchasing?");
                double child = double.Parse(System.Console.ReadLine());
                double totalChildcost = child * 3.99;

                System.Console.Write("How many Adult tickets are you puchasing?");
                double adult = double.Parse(System.Console.ReadLine());
                double totalAdultcost = adult * 5.99;

                System.Console.Write("How many Senior tickets are you purchasing?");
                double senior = double.Parse(System.Console.ReadLine());
                double totalSeniorcost = senior * 4.50;

                totalCost = totalAdultcost + totalChildcost + totalSeniorcost;

                totalPeople = child + adult + senior;
                System.Console.WriteLine("Your total number of tickets is: " + totalPeople);
                System.Console.WriteLine("Your total cost in tickets is: $ " + totalCost);

            }
            else if (movieTimes == "Evening")
            {
                System.Console.WriteLine("Your purchase is for Evening!");

                System.Console.Write("How many Children tickets are you purchasing?");
                double child = double.Parse(System.Console.ReadLine());
                double totalChildcost = child * 6.99;

                System.Console.Write("How many Adult tickets are you puchasing?");
                double adult = double.Parse(System.Console.ReadLine());
                double totalAdultcost = adult * 10.99;

                System.Console.Write("How many Senior tickets are you purchasing?");
                double senior = double.Parse(System.Console.ReadLine());
                double totalSeniorcost = senior * 8.50;

                totalCost = totalAdultcost + totalChildcost + totalSeniorcost;

                totalPeople = child + adult + senior;
                System.Console.WriteLine("Your total number of tickets is: " + totalPeople);
                System.Console.WriteLine("Your total cost in tickets is: $ " + totalAdultcost + totalChildcost + totalSeniorcost);

                if (totalPeople >= 3)
                {
                    System.Console.WriteLine("Since you have purchased " + totalPeople + " tickets, you get 1 free bag of popcorn!");
                }
            }
            else
            {
                System.Console.WriteLine("I'm sorry I couldn't understand. Please start over ");
            }

            System.Console.WriteLine("Would you like to buy anything from the Concession stand? Yes or No: ");
            string snacks = System.Console.ReadLine();

            if (snacks == "Yes")
            {

                System.Console.Write("How many Small Sodas? ");
                smallsoda = double.Parse(System.Console.ReadLine());
                smallsoda = (smallsoda * 3.50);

                System.Console.Write("How many Large Sodas? ");
                largesoda = double.Parse(System.Console.ReadLine());
                largesoda = (largesoda * 5.99);

                System.Console.Write("How many Hot Dogs? ");
                hotdogs = double.Parse(System.Console.ReadLine());
                hotdogs = (hotdogs * 3.99);

                System.Console.Write("How many Popcorns? ");
                popcorns = double.Parse(System.Console.ReadLine());
                popcorns = (popcorns * 4.50);

                System.Console.Write("How many Candies ?");
                candies = double.Parse(System.Console.ReadLine());
                candies = (candies * 1.99);

                concessionStand = smallsoda + largesoda + hotdogs + popcorns + candies;

                if ((popcorns > 0) && (largesoda > 0))
                {
                    System.Console.WriteLine("Since you have purchased a large popcorn and a large soda, you recieved a $2 discount.");
                    System.Console.WriteLine("Your total is now: $" + (concessionStand - 2));
                }
                if (candies >= 5.97)
                {
                    System.Console.WriteLine("You have purchased 3 candies , so you get one free!");
                }

            }
            else
            {
                System.Console.WriteLine("You don't have any snack, have fun!!!!");
            }

            System.Console.WriteLine("Press any key to end...");

            System.Console.ReadKey();
        }
    }
}
