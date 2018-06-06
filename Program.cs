using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use of a while loop to keep program running until user decides they are done
            bool isRunning = true;
            while (isRunning)
            {
                //Greet the user and ask for input
                Console.WriteLine("Hello there! Please enter two whole numbers of the same length.");
                Console.WriteLine("This program will check the sums of all corresponding");

                //Store the user input
                Console.Write("First Number : ");
                string input1 = Console.ReadLine();
                Console.Write("Second Number : ");
                string input2 = Console.ReadLine();

                // Run IndexSumsCompare method 
                Console.WriteLine(IndexSumsCompare(input1, input2));
                // Run again or terminate program based on user input
                Console.WriteLine("Would you like to run the program again? Y / N");
                string playAgain = Console.ReadLine();
                if (playAgain == "Y" || playAgain == "y")
                {
                    isRunning = true;
                }
                else
                {
                    isRunning = false;
                }
            }
        }

        private static bool IndexSumsCompare(string num1, string num2)
        {
            // Validate that one or both inputs are not empty
            if (num1 == "" || num2 == "")
            {
                Console.WriteLine("Sorry but a there must be a value in both inputs");
            }
            // Validate that the Length of both inputs match
            if (num1.Length != num2.Length)
            {
                Console.WriteLine("Sorry but your numbers do not match in length...please try again");
            }
            // Validate both inputs are numbers
            if (!((num1.All(Char.IsDigit) && num2.All(Char.IsDigit))))
            {
                Console.WriteLine("Sorry but both inputs must be whole numbers");
            }


            // Variable to store the sum of both numbers at index 1
            int sumToCompare = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                // try catch to handle index out of bounds Exception
                try
                {
                    // Variable that sets comparison on first run
                    // then is checked against on 2nd run
                    int indexSum = (int)num1[i] + (int)num2[i];
                    if (i == 0)
                    {
                        // Set comparison on first run
                        sumToCompare = indexSum;
                    }
                    else
                    {
                        // Compare with other index sums
                        // If sums dont match on 2nd run program stops here
                        if (sumToCompare != indexSum)
                        {
                            return false;
                        }
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            // All index sums match
            return true;
        }
    }
}
