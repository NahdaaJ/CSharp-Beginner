﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Section_5___Control_Flow
{
    class Exercise1
    {
      static void Main(string[] args)            
        {
            // Exercise 1.1
            // Write a program and ask the user to enter a number.
            // The nymber should be between 1 to 10.
            // If the user enters a valid number, display "valid" on the console.
            // Otherwise, display "Invalid".
            /*
            int userInput;
            string strUserInput;

            Console.WriteLine("Please enter a number between 1 and 10 inclusive: ");
            strUserInput = Console.ReadLine();
            userInput = Convert.ToInt32(strUserInput);

            if (userInput<11 && userInput>0)
            {
                Console.WriteLine("Valid Input.");
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
            */

            //----------------------------------------------------------------------------------------------------------

            // Exercise 1.2
            // Write a program which takes two numbers from the console and displays the maximum of the two.
            /*
            string strUserInput1;
            string strUserInput2;
            int userInput1;
            int userInput2;

            Console.WriteLine("Please enter any number: ");
            strUserInput1 = Console.ReadLine();
            Console.WriteLine("Please enter another number: ");
            strUserInput2 = Console.ReadLine(); 

            userInput1 = Convert.ToInt32(strUserInput1);
            userInput2 = Convert.ToInt32(strUserInput2);    

            if(userInput1>userInput2)
            {
                Console.WriteLine("{0} was the greater number.", strUserInput1);
            }
            else if (userInput2>userInput1)
            {
                Console.WriteLine("{0} was the greater number.", strUserInput2);
            }
            else
            {
                Console.WriteLine("You entered {0} twice, so there is no greater number", strUserInput1);
            }
            */

            //------------------------------------------------------------------------------------------------------
            
            //Exercise 1.3
            // Write a program and ask the user to enter the width and height of an image.
            // Then tell if the image is landscape or portrait.
            /*
            int width;
            int height;

            Console.WriteLine("Please enter the width of the image:");
            width = Convert.ToInt32(Console.ReadLine());    
            
            Console.WriteLine("Please enter the height of the image");
            height = Convert.ToInt32(Console.ReadLine());


            if (width > height)
            {
                Console.WriteLine("Your image is in Landscape.");
            }
            else if (height > width)
            {
                Console.WriteLine("Your image is in Portrait.");
            }
            else
            {
                Console.WriteLine("Your image is a square, it is neither landscape nor portrait.");
            }
            */
        }   
    }
}
