using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Section_5___Control_Flow
{
    class Exercises
    {
      static void Main(string[] args)            
        {

            // Exercise 1.4
            // Write a program that prompts the user to enter the speed limit.
            // Once set, the program asks for the speed of a car. 
            // If the user enters a value less that the speed limit, program should display "ok".
            // If the value is above the speed limit, the program should calculate the number of demerit points.
            // For every 5km/hr above the speed limit, 1 demerit point is incurred and displayed.
            // If demerit point exceeds 12, program should display license suspended.

            /*
            int speedLimit;
            int carSpeed;
            int speedDiff;
            int deMerit;

            Console.WriteLine("Please enter the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of your car: ");
            carSpeed = Convert.ToInt32(Console.ReadLine());


            if (carSpeed > speedLimit)
            {
                speedDiff = carSpeed - speedLimit;
                deMerit = speedDiff / 5;

                if (deMerit > 11)
                {
                    Console.WriteLine("You were travelling at a whopping {0}, which is {1} over the speed limit!",carSpeed, speedDiff);
                    Console.WriteLine("You have been given {0} demerits, and your license has been suspended.",deMerit);
                }
                else
                {
                    Console.WriteLine("You were travelling at a whopping {0}, which is {1} over the speed limit!", carSpeed, speedDiff);
                    Console.WriteLine("You have been given {0} demerits.", deMerit);
                }
            }
            else
            {
                Console.WriteLine("Your speed is okay! Good job citizen.");
            }
            */

            //-----------------------------------------------------------------------------------------------------------------

            // Exercise 2.1
            // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            // Display the count on the console.
            /*
            int i;
            int numCount=0;

            Console.WriteLine("The following numbers are divisible by 3:");
            for (i=1;i<=100;i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    numCount++;
                }
            }

            Console.WriteLine("{0} numbers between 1 and 100 inclusive are divisible by 3.", numCount);
            */

            //------------------------------------------------------------------------------------------------------------------

            // Exercise 2.2
            // Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console.
            /*
            int userInput;
            string checkNull;
            int numSum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or press enter to see final sum: ");
                checkNull = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(checkNull))
                {
                    userInput = Convert.ToInt32(checkNull);
                    numSum = numSum + userInput;
                    continue;

                }
                break;              
            }

            Console.WriteLine("Your final sum is: {0}", numSum);
            */

            //-------------------------------------------------------------------------------------------------------------

            // Exercise 2.3
            // Write a program and ask the user to enter a number.
            // Compute the factorial of the number and print it on the console.
            /*
            int userInput;
            int i;
            int finalFactorial = 1;

            Console.WriteLine("Enter a number: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            for (i=1; i<=userInput; i++)
            {
                finalFactorial *= i;
            }
            
            Console.WriteLine("The factorial of {0} is {1}",userInput,finalFactorial); ;
            */

            //-------------------------------------------------------------------------------------------------------------

            // Exercise 2.4
            // Write a program that picks a random number between 1 and 10.
            // Give the user 4 chances to guess the number.
            // If the user guess the number, say "you won".
            // Otherwise, display "you lost".
            /*
            int numGuesses=4;
            var random = new Random();
            int randNum = Convert.ToInt32(random.Next(1, 10));
            int userGuess;

            Console.WriteLine("The program has chosen a random number between and including 1 and 10.");
            Console.WriteLine("You have 4 guesses to guess the number!");
            Console.WriteLine("Your first guess:");
            userGuess = Convert.ToInt32(Console.ReadLine());

            while (numGuesses!=0)
            {
                if (userGuess!= randNum)
                {                
                Console.WriteLine("Nice try, but that is incorrect.");
                Console.WriteLine("You have {0} guesses left, please try again: ", numGuesses);
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    numGuesses--;
                }
                else
                {
                    Console.WriteLine("Congradulations! {0} was the correct number!", randNum);
                    break;
                }

            }

            if (numGuesses==0) 
            {
                Console.WriteLine("Oh no! You ran out of guesses. The number was {0}. Better luck next time!", randNum); 
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
            */

            //---------------------------------------------------------------------------------------------------------------

            // Exercise 2.5
            // Write a program and ask the suer to enter a series of numbers separated by a comma.
            // Find the maximum of the numbers and display it on the console.
            /*
            int i=0;
            int maxElement=0;

            Console.WriteLine("Enter a sequence of numbers, split by a ',' with no spaces:");
            string userInput = Console.ReadLine();

            string[] userList = userInput.Split(",");
            int[] intUser = new int[userList.Length]; 

            foreach(string item in userList)
            {
                intUser[i] = Convert.ToInt32(item);
                i++;
                maxElement = Convert.ToInt32(item);
            }

            foreach(int integer in intUser)
            {
                if (integer > maxElement)
                {
                    maxElement = integer;
                }
            }
            Console.WriteLine("The highest value of all the values you have entered was {0}.",maxElement);
            */

            /*
            // Exercise 1.1
            // Write a program and ask the user to enter a number.
            // The nymber should be between 1 to 10.
            // If the user enters a valid number, display "valid" on the console.
            // Otherwise, display "Invalid".

            Console.WriteLine("Please enter a number between 1 and 10 inclusive: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var isValid = NumberChecker(userInput);
            Console.WriteLine(isValid);
            */

            //-------------------------------------------------------------------------------------------------

            /*
            // Exercise 1.2
            // Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Please enter a number: ");
            var userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            var userInput2 = Convert.ToInt32(Console.ReadLine());

            var highestNum = DisplayMax(userInput1, userInput2);
            Console.WriteLine("The highest of the two numbers you have given is " + highestNum);
            */

            //---------------------------------------------------------------------------------------------------

            /*
            // Exercise 1.3
            // Write a program and ask the user to enter the width and height of an image.
            // Then tell if the image is landscape or portrait.

            Console.WriteLine("Please enter the width of your image: ");
            var imageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of your image: ");
            var imageHeight = Convert.ToInt32(Console.ReadLine());

            var imageOrientation = LandscapeOrPortrait(imageWidth, imageHeight);
            Console.WriteLine("The orientation of your image is "+ imageOrientation);
            */

            //---------------------------------------------------------------------------------------------------

            /*
            // Exercise 1.4
            // Write a program that prompts the user to enter the speed limit.
            // Once set, the program asks for the speed of a car. 
            // If the user enters a value less that the speed limit, program should display "ok".
            // If the value is above the speed limit, the program should calculate the number of demerit points.
            // For every 5km/hr above the speed limit, 1 demerit point is incurred and displayed.
            // If demerit point exceeds 12, program should display license suspended.

            Console.WriteLine("Please enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            var isSpeeding = CarSpeedChecker(speedLimit, carSpeed);

            if (isSpeeding >= 0 && isSpeeding < 12)
                Console.WriteLine("You have been issued {0} demerits", isSpeeding);
            else if (isSpeeding > 12)
                Console.WriteLine("Your license has been suspended.");
            else
                Console.WriteLine("Good speed.");
            */

        }

        public static string NumberChecker(int number)
        {
            if (number < 11 && number > 0)
                return "Valid";

            else
                return "Invalid";
        }

        public static int DisplayMax(int number1, int number2)
        {
            int greaterNum;

            if (number1 > number2)
                greaterNum = number1;
            else if (number2 > number1)
                greaterNum = number2;
            else
                greaterNum = number1;

            return greaterNum;
        }

        public static string LandscapeOrPortrait(int width, int height)
        {
            string orientation;

            if (width > height)
                orientation = "Landscape";
            else if (height > width)
                orientation = "Portrait";
            else
                orientation = "Neither";

            return orientation;
        }

        public static int CarSpeedChecker(int limit, int speed)
        {
            int demerit;
            if (speed > limit)
            {
                var speedDiff = speed - limit;
                demerit = speedDiff / 5;

                return demerit;
            }
            else
            {
                return -1;
            }
        }

    }
}
