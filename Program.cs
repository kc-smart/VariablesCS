using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            /*Explorer Mode*/

            //Creating Variables
            int numberOfCupsOfCoffee = 1;
            string fullName = "Kayla Smart";
            var today = DateTime.Now;
            Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);

            //Getting User Input
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Greetings, " + userName + ".");


            //Getting Different Input Types From User
            Console.Write("Please enter two numbers: ");
            string firstNumberAsString = Console.ReadLine();
            string secondNumberAsString = Console.ReadLine();

            //Convert String to Double
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);

            //Do Math
            double sum = firstOperand + secondOperand;
            double difference = secondOperand - firstOperand;
            double product = firstOperand * secondOperand;
            double quotient = firstOperand / secondOperand;
            double remainder = firstOperand % secondOperand;

            //Output
            Console.WriteLine("You entered " + firstOperand + " and " + secondOperand + ".\n"
            + firstOperand + " plus " + secondOperand + " equals " + sum + ".\n"
            + secondOperand + " minus " + firstOperand + " equals " + difference + ".\n"
            + firstOperand + " times " + secondOperand + " equals " + product + ".\n"
            + firstOperand + " divided by " + secondOperand + " equals " + quotient + ".\n"
            + firstOperand + " mod " + secondOperand + " leaves a remainder of " + remainder + ".\n");


            /*Adventure Mode*/

            //Use Logic
            Console.Write("Please enter your name: ");
            string userNameTwo = Console.ReadLine();
            if (userNameTwo == "Alice")
            {
                Console.WriteLine("Her name is AAAAAALLLLLLLIIIIIIIIIICCCCCCCCEEEE! She crawls into the window through shapes and shadows. AAAAAALLLLLLLIIIIIIIIIICCCCCCCCEEEE! And even though she's dreaming, she knows...");
            }
            else
            {
                Console.WriteLine("Greetings, " + userNameTwo + ".");
            }

            //Use DateTime


            /*Epic Mode*/
            //Move Code to New Method and Call Main





        }
    }
}
