using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_6___Arrays_and_Lists
{
    internal class Exercises
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Find exercise prompt in README.md
            /*
            string userInput;
            int otherLikes;
            var namesList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name or press enter to continue with program:");
                userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    namesList.Add(userInput);
                }
                else
                {
                    break;
                }
            }

            if (namesList.Count == 1) 
            {
                Console.WriteLine("{0} liked your post!", namesList[0]);
            }
            else if (namesList.Count == 2) 
            {
                Console.WriteLine("{0} and {1} liked your post!", namesList[0], namesList[1]);
            }
            else if (namesList.Count == 3)
            {
                Console.WriteLine("{0}, {1} and 1 other liked your post!", namesList[0], namesList[1]);
            }
            else if (namesList.Count > 3)
            {
                otherLikes = namesList.Count - 2;
                Console.WriteLine("{0}, {1} and {2} others liked your post!", namesList[0], namesList[1], otherLikes);
            }
            */

            //-----------------------------------------------------------------------------------------------------------------

            // Exercise 2
            // Write a program and ask the user to enter their name.
            // Use an array to reverse the nae and then store the result in a new string.
            // Display the reversed name on the console.
            /*
            string userInput;

            Console.WriteLine("Please enter your name: ");
            userInput = Console.ReadLine();

            char[] userName = userInput.ToCharArray();
            Array.Reverse(userName);

            Console.WriteLine("Your name reversed is: ");
            foreach (char c in userName)
            {
                Console.Write(c);
            }
            */

            //-----------------------------------------------------------------------------------------------------------------

            // Exercise 3
            // Write a program and ask the user to enter 5 numbers.
            // If a number has been previously entered, display an error message and ask the user to retry.
            // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
            /*
            int[] userInput = new int[5];
            int numberList;

            while(true)
            {
                int i = 0;
                Console.WriteLine("Please enter 5 unique numbers, after each number press enter:");
                foreach (int number in userInput)
                {
                    numberList = Convert.ToInt32(Console.ReadLine());
                    userInput[i] = numberList;
                    i++;
                }

                int isDuplicate = userInput.Distinct().Count();
                if (isDuplicate != 5 ) 
                {
                    Console.WriteLine("You have not entered 5 unique numbers, please try again.");
                }
                else
                {
                    break;
                }
            }
            Array.Sort(userInput);
            Console.WriteLine("\nYour 5 unique numbers sorted from lowest to highest is:");
            foreach(int number in userInput)
            {
                Console.Write("{0} ",number);
            }
            Console.WriteLine();
            */

            //----------------------------------------------------------------------------------------------------------------

            // Exercise 4
            // Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            // The list of numbers may include duplicates.
            // Display the unique numbers that the user has entered.
            /*
            var userNumbers = new List<int>();

            while(true)
            {
                Console.WriteLine("Please enter a number or type 'quit' to exit:");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    break;
                }
                else
                {
                    int intUser = Convert.ToInt32(userInput);
                    userNumbers.Add(intUser);

                }
            }

            var IsDuplicate = userNumbers.Distinct().ToList();
            Console.WriteLine("You have entered the following unique elements: ");
            foreach (int intUser in IsDuplicate)
            {
                Console.Write("{0} ",intUser);
            }
            */

            //------------------------------------------------------------------------------------------------------------

            // Exercise 5
            // Write a program and ask the user to supply a list of comma separated numbers.
            // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to retry.
            // Otherwise, display the 3 smallest numbers in the list.
            /*
            string[] userList;
            int[] userNumbers;

            while(true)
            {
                int i = 0;
                Console.WriteLine("Please enter a list of numbers, separated by a comma: ");
                string userInput = Console.ReadLine();

                userList = userInput.Split(",");
                userNumbers = new int[userList.Length];

                if (userList.Length < 5 ) 
                {
                    Console.WriteLine("Please enter at least 5 numbers:");
                    continue;
                }
                else
                {
                    break;
                }                
            }

            int j = 0;
            foreach (string item in userList)
                {
                    userNumbers[j] = Convert.ToInt32(item);
                    j++;
                }

            Array.Sort(userNumbers);
            Console.WriteLine("\nThe smallest numbers in your list are: ");
            for (int i = 0; i<=2; i++)
            {
                Console.Write("{0} ", userNumbers[i]);
            }

            var isDistinct = userNumbers.Distinct().ToList();
            Console.WriteLine("\nThe unique smallest numbers in your list are:");
            for (int i = 0; i <= 2; i++)
            {
                Console.Write("{0} ", isDistinct[i]);
            }
            Console.WriteLine();
            */
        }
    }
}
