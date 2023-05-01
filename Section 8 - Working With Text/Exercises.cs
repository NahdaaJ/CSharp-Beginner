using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Section_8___Working_With_Text
{
    internal class Exercises
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Write a program and ask the user to enter a few numbers separated by a hyphen.
            // Work out if the numbers are consecutive.
            // Display message: "Consecutive" or "Not Consectuive"
            /*
            Console.WriteLine("Please enter a series of numbers, separated by a hyphen (-): ");
            var userInput = Console.ReadLine();
            var splitInput = userInput.Split('-'); // Splitting the user string using the hyphen.

            int toNumber; // Used to convert the strings to ints.
            var userNumbers = new List<int>(); // Storing the users numbers in a list.
            var comparisonList = new List<int>(); // Storing what a consecutive lists elements would be.

            // Converting each split string into an int, then storing it.
            foreach (var line in splitInput)
            {
                toNumber = Convert.ToInt32(line);
                userNumbers.Add(toNumber);
            }

            // Giving comparisonList the same starting element as userNumbers, so we know where the numerical chain begins.
            comparisonList.Add(userNumbers[0]);

            // If the first element of userNumbers is smaller than the second, the consecutive numbers in comparisonList go up by 1.
            if (userNumbers[0] < userNumbers[1])
            {
                for (int i = 0; i<userNumbers.Count-1; i++)
                {
                    comparisonList.Add(comparisonList[i] + 1);
                }
            }
            // If the first element of userNumbers is larger than the second, the consecutive numbers in comparisonList go down by 1.
            else
            {
                for (int i = 0; i < userNumbers.Count-1; i++)
                {
                    comparisonList.Add(comparisonList[i] - 1);
                }
            }

            // Checking if userNumbers is the same as comparisonList.
            var isSame  = userNumbers.SequenceEqual(comparisonList);
            if (isSame) // If they are the same, that means userNumbers is consecutive too.
            {
                Console.WriteLine("Your numbers are consecutive.");
            }
            else // If they are not the same, that means userNumbers is not consecutive.
            {
                Console.WriteLine("Your numbers are not consecutive.");
            }
            */

            //--------------------------------------------------------------------------------------------------------------------

            // Exercise 2
            // Write a program and ask the user to enter a few numbers separated by a hyphen.
            // If the user simply presses enter, without supplying an input, exit immediately.
            // Otherwise, check to see if there are duplicates.
            // If so, display "Duplicate" on the console.
            /*
            Console.WriteLine("Please enter a series of numbers, separated by a hyphen (-): ");
            var userInput = Console.ReadLine(); // Storing user input.

            if (String.IsNullOrWhiteSpace(userInput)) // If input is null, empty or whitespace, the program ends.
            {
                return;
            }

            var splitInput = userInput.Split('-'); // Splitting the user string using the hyphen, storing in a list.
            var userNumbers = new List<int>(); // List to store the integer user numbers.
            int toNumber;
            
            foreach ( var line in splitInput) // Each element in thelist is converted to an int, then appended to userNumbers.
            {
                toNumber = Convert.ToInt32(line);
                userNumbers.Add(toNumber);
            }

            var duplicate = userNumbers.Distinct().Count(); // Calculating the number of unique/distinct values.
            // If the number of unique values is not equal to the number of elements, there are duplicate numbers in the list.
            if(duplicate != userNumbers.Count)
            {
                Console.WriteLine("There are duplicate numbers.");
            }
            else
            {
                Console.WriteLine("There are no duplicate numbers.");
            }
            */

            //--------------------------------------------------------------------------------------------------------------------------------

            // Exercise 3
            // Write a program and ask the user to enter a time value in the 24-hour time format.
            // A valid time should be between 00:00 and 23:59.
            // If the time is valid, display "Ok";
            // Otherwise, display "Invalid Time".
            // If the user doesn't provide any values, consider it as invalid time.
            /*
            Console.WriteLine("Please enter a time value in the 24-hour time format.");
            var userTime = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userTime))
            {
                Console.WriteLine("Invalid Time.");
                return;
            }

            var hourMin = userTime.Split(":");
            var userHour = Convert.ToInt32(hourMin[0]);
            var userMin = Convert.ToInt32(hourMin[1]);

            if (userHour < 0 || userHour > 23)
            {
                Console.WriteLine("Invalid Time.");
                return;
            }

            if (userMin < 0 || userMin > 59)
            {
                Console.WriteLine("Invalid Time.");
                return;
            }

            Console.WriteLine("Valid Time.");
            */

            //-----------------------------------------------------------------------------------------------------------------------------

            // Exercise 4
            // Write a program and ask the user to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase.
            // Make sure that the program is not dependant on the input. 
            // So if the user types in all caps, it still works.
            /*
            Console.WriteLine("Please enter a few words separated by a space: ");
            var userInput = Console.ReadLine().ToLower(); // Converting the entire user input string to lowercase.
            var userString = userInput.Split(' ');

            int i = 0;
            Console.WriteLine("\nYour input as a variable name in Pascal Case is:");
            foreach (var word in userString) // For each element in userString:
            {
                var toUpper = word.Substring(0,1).ToUpper(); // Set toUpper as the first letter, and uppercase the letter.
                char character = char.Parse(toUpper); // As toUpper is a string, convert it to a char to use in the next line.
                var newWord = word.Remove(0,1).Insert(0, toUpper); // Remove the first letter, insert toUpper as the first letter.
                Console.Write(newWord); // Write each element on the same line with no space, like a variable name.
                i++;
            }
            Console.WriteLine(); // Adding extra space for readability.
            */

            //-----------------------------------------------------------------------------------------------------------------

            // Exercise 5
            // Write a program and ask the user to enter an English word.
            // Count the number of vowels (a,e,o,u,i) in the word.
            // Display it on the console
            Console.WriteLine("Please enter a word: ");
            var userInput = Console.ReadLine().ToLower();

            var characters = userInput.ToList();
            int numVowels = 0;
            foreach (var ch in characters)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    numVowels++;
                }
            }

            Console.WriteLine("Your word had {0} vowels.", numVowels);
        }
    }
}