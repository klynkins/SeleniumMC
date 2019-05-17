using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.World
{
    class Program
    {
        //int somenumber;

        static void Main(string[] args)
        {
            //int number1 = 0;
            //char holdsALetter = 'a';
            //double amount;

            //amount = 2.5;

            //ask the user a question//
            //Console.WriteLine("What is your favourite number?");
            //int number;
            //number = Convert.ToInt32(Console.ReadLine());

            /*
            //variables//
            string userFirstName;
            string age;

            //ask the user their name//
            Console.WriteLine("What is your first name?");
            userFirstName = Console.ReadLine();

            //ask the user their age//
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            //concatenation//
            //string response = "Your name is: " + userFirstName + " and you are " + age + " years old";
            //interpolation//
            string response = $"Your name is: {userFirstName} and you are {age} years old";


            //print put response//
            Console.WriteLine(response);
            Console.ReadLine(); 
            */

            //variables//
            string itemName = "Widget";
            double pricePerOunce = 17.36;
            string outputString;

            //format output
            //outputString = String.Format("The current price is {0:C}", pricePerOunce);
            outputString = String.Format("{0,10} {1,10}", itemName, pricePerOunce);

            //output to the user
            Console.WriteLine(String.Format("{0,10} {1,10}", "Item Name", "Price"));
            Console.WriteLine(outputString);
            Console.ReadLine();
        }
    }
}
